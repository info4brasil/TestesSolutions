using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace FileValidator
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TViewModel"></typeparam>
    /// <typeparam name="TVAL"></typeparam>
   public class FileManager<TViewModel,KValidator>  where KValidator: AbstractValidator<TViewModel>
    {
        /// <summary>
        /// Preenche o objeto de acordo com o nome da coluna e valor 
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>Retorna o obj do tipo generic T </returns>

        public TViewModel FillObject(string[] columnName,string[] values)
        {
            Object obj = Activator.CreateInstance(typeof(TViewModel));

            for (int i = 0; i < columnName.Length; i++)
            {
                 var property =  obj.GetType().GetProperty(columnName[i]);

                switch (property.PropertyType.Name)
                {
                    case nameof(String):
                        try
                        {
                            property.SetValue(obj, values[i]);
                        }
                        catch (Exception)
                        {
                            property.SetValue(obj, null);
                        }
                       
                        break;

                    case nameof(DateTime):
                        try
                        {
                            property.SetValue(obj, DateTime.Parse(values[i]));
                        }
                        catch (Exception)
                        {

                            property.SetValue(obj, null);
                        }
                       
                        break;

                    case nameof(Int32):
                        try
                        {
                           property.SetValue(obj, int.Parse(values[i]));
                        }
                        catch (Exception)
                        {
                            property.SetValue(obj, null);
                        }
                      
                        break;
                }           
            }
                     
            return (TViewModel) obj ;
        }

        public void Validar(Object obj )
        {  
           var validator =(KValidator) Activator.CreateInstance(typeof(KValidator));                 
           var result = validator.Validate((TViewModel)obj);

            foreach (var item in result.Errors)
            {
                Trace.WriteLine(item.ErrorMessage);

            }

        }


        public void Processar(string fileName)
        {

            string[] lines = File.ReadAllLines(fileName);
            string[] columns = lines[0].Split(';');

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(';');
                var retorno =   FillObject(columns, values);
                Validar(retorno);
            }


        }



    }
}
