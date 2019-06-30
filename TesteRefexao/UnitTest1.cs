using System;
using System.Collections.Generic;
using FileValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViewModels;

namespace TesteRefexao
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileManager<UserDTO, TesteValidator> fileManager = new FileManager<UserDTO, TesteValidator>();
            //var r = fileManager.fillObj(new List<string[]>() {
            //   new String[]{ nameof(UserDTO.ID),"10" },
            //   new String[]{ nameof(UserDTO.Name),"Cleber Araujo" },
            //   new String[]{ nameof(UserDTO.DateOfBirth),"25/11/1982" }
            //});

            string path ="teste.txt";

            fileManager.Processar(path);
        }
    }
}
