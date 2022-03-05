﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FANTASY4YOU;


namespace FANTASY4YOU
    
{
    public class Logic
    {
        ConnectionToDatabase connection = new ConnectionToDatabase();
        ImportantInfo importantInfo = new ImportantInfo();

        //Has NunitTest
        public int SelectUserId()
        {
            string username = ReadUsernameFromUsernameFile();
            int id= connection.SelectUserIdFromDB(username);
            return id;

        }

        //Cannot be tested
        public void InsertCharacterDetails(string characterName, string classs, int level, string race, string backgroundStory, int xpPoints, string alignment)
        {
            int numberOfCharacter = NumberOfCharactersCreated();
            int characterNumber = 0;
            switch (numberOfCharacter)
            {
                case 0:
                    characterNumber = 1;
                    break;
                case 1:
                    characterNumber = 2;
                    break;
                case 2:
                    characterNumber = 3;
                    break;
                case 3:
                    characterNumber = 4;
                    break;
                case 4:
                    characterNumber = 5;
                    break;
                //case 5:
                //    characterNumber = 5;
                //    break;
            }

            string username = ReadUsernameFromUsernameFile();
            connection.InsertCharacterDetails(username, characterName, classs, level, race, backgroundStory, xpPoints, alignment, characterNumber);
        }

        public void UpdateCharacterDetails(int chNumber, int strenght, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            int id = SelectUserId();
            connection.UpdateCharacterDetails(chNumber, id, strenght, dexterity, constitution, intelligence, wisdom, charisma);
        }

        public void UpdateCharacterDetails2(int chNumber, string chName, string classs, int level, string race, int xp, string alignment)
        {
            int id = SelectUserId();
            connection.UpdateCharacterDetails2(chNumber, id, chName, classs, level, race, xp, alignment);
        }

        public void UpdateCharacterDetails3(int chNumber,string background)
        {
            int id = SelectUserId();
            connection.UpdateCharacterDetails3(chNumber, id, background);
        }


        public void InsertCharacterDetails2(string characterName, string classs, int level, string race, string backgroundStory, int xpPoints, string alignment)
        {
            int numberOfCharacter = NumberOfCharactersCreated();
            int characterNumber = 0;
            switch (numberOfCharacter)
            {
                case 0:
                    characterNumber = 1;
                    break;
                case 1:
                    characterNumber = 2;
                    break;
                case 2:
                    characterNumber = 3;
                    break;
                case 3:
                    characterNumber = 4;
                    break;
                case 4:
                    characterNumber = 5;
                    break;
                    //case 5:
                    //    characterNumber = 5;
                    //    break;
            }

            string username = ReadUsernameFromUsernameFile();
            connection.InsertCharacterDetails(username, characterName, classs, level, race, backgroundStory, xpPoints, alignment, characterNumber);
        }

        //Cannot be tested
        public void SavePassword(string password)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.fileName;
            var roaming = importantInfo.roamingpath;
            var newdir = (roaming + path);
            Directory.CreateDirectory(newdir);
            var newfilepath = Path.Combine(newdir, fileName);
            var filename1 = File.Create(newfilepath);
            var sw = new StreamWriter(filename1);
            sw.WriteLine(password);
            sw.Close();
        }

        public void saveCharSelectedToEditToFile(int charNumber)
        {
            if (!File.Exists(importantInfo.CharNumPath) || charNumber != readCharSelectedToEditFile())
            {
                string path = importantInfo.Path;
                string fileName = importantInfo.CharSelectedTempFilename;
                var roaming = importantInfo.roamingpath;
                var newdir = (roaming + path);
                var filePath = Path.Combine(newdir, fileName);
                var file = File.Create(filePath);
                var sw = new StreamWriter(file);
                sw.Write(charNumber);
                sw.Close();
            }
            
        }

        public int readCharSelectedToEditFile()
        {
            int charNum;
            string path = importantInfo.Path;
            string fileName = importantInfo.CharSelectedTempFilename;
            var roaming = importantInfo.roamingpath;
            var newdir = (roaming + path);
            var filePath = Path.Combine(newdir, fileName);
            var sr = new StreamReader(filePath);

            try
            {
                string line = sr.ReadLine();
                charNum = Int32.Parse(line); ;
                sr.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return charNum;
        }

        public void deleteCharSelectedToEditFile()
        {
            var CharNumPath = (importantInfo.CharNumPath);
            if (File.Exists(CharNumPath))
            {
                File.Delete(CharNumPath);
            }
            
        }

        public void saveCharSelectedToDisplayToFile(int charNumber)
        {
            if (!File.Exists(importantInfo.CharDispPath) || charNumber != readCharSelectedToDisplayFile())
            {
                string path = importantInfo.Path;
                string fileName = importantInfo.CharSelectedTempDisplayFilename;
                var roaming = importantInfo.roamingpath;
                var newdir = (roaming + path);
                var filePath = Path.Combine(newdir, fileName);
                var file = File.Create(filePath);
                var sw = new StreamWriter(file);
                sw.Write(charNumber);
                sw.Close();
            }

        }

        public int readCharSelectedToDisplayFile()
        {
            int charNum;
            string path = importantInfo.Path;
            string fileName = importantInfo.CharSelectedTempDisplayFilename;
            var roaming = importantInfo.roamingpath;
            var newdir = (roaming + path);
            var filePath = Path.Combine(newdir, fileName);
            var sr = new StreamReader(filePath);

            try
            {
                string line = sr.ReadLine();
                charNum = Int32.Parse(line); ;
                sr.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return charNum;
        }

        public void deleteCharSelectedToDisplayFile()
        {
            var CharNumPath = (importantInfo.CharDispPath);
            if (File.Exists(CharNumPath))
            {
                File.Delete(CharNumPath);
            }

        }
        //Has NunitTest
        public List<string>[] SelectCharacterInformation(int characterNumber)
        {
            string username = ReadUsernameFromUsernameFile();
            List<string>[] list = connection.SelectCharacterInformation(username,characterNumber);
            return list;
        }

        public List<string>[] SelectCharacterInformation2(int characterNumber)
        {
            string username = ReadUsernameFromUsernameFile();
            List<string>[] list = connection.SelectCharacterInformation2(username, characterNumber);
            return list;
        }

        //Cannot be tested
        public void SaveCredentialsToFile(string username,string password)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.fileName;
            var roamingDirectory = importantInfo.roamingpath;
            var newDirPath = (roamingDirectory+ path);
            
            if (Directory.Exists(newDirPath))
            {
                var newFilePath = Path.Combine(newDirPath, fileName);
                var filestream = File.Create(newFilePath);

                var sw = new StreamWriter(filestream);
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.Close();
            }
            else 
            {
                Directory.CreateDirectory(newDirPath);
                var newFilePath = Path.Combine(newDirPath, fileName);
                var filestream = File.Create(newFilePath);

                var sw = new StreamWriter(filestream);
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.Close();
            }
            
        }

        //Has NunitTest
        public int NumberOfCharactersCreated()
       {
           int id = SelectUserId();
           int numbersOfCharacters;
           numbersOfCharacters = connection.NumberOfCharactersCreated(id);
           return numbersOfCharacters;
       }

        //Cannot be tested
        public void SaveUsernameToFile(string username)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.UsernameFilename;
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + path);
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, fileName);
            var fileStream = File.Create(newFilePath);

            var sw = new StreamWriter(fileStream);
            sw.WriteLine(username);
            sw.Close();
        }

        //Has NunitTest
        public string ReadUsernameFromUsernameFile()
        {
            string username = null;
            string path = importantInfo.Path;
            string fileName = importantInfo.UsernameFilename;
            var roamingDirectory = importantInfo.roamingpath;
            var newDirPath = (roamingDirectory + path);
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, fileName);
            var sr = new StreamReader(newFilePath);
            
            try
            {
                string line = sr.ReadLine();
                username = line;
                sr.Close();
            }
            catch (Exception ex)
            {

            }
            return username;
        }

        //Has NunitTest
        public string ReadUsernameFromCredentialsFile()
        {
            string username = null;
            string fileName = importantInfo.fileName;
            Directory.CreateDirectory(importantInfo.crdDir);
            var newFilePath = Path.Combine(importantInfo.crdDir, fileName);
            var sr = new StreamReader(newFilePath);

            try
            {
                string line = sr.ReadLine();
                username = line;
                sr.Close();
            }
            catch (Exception ex)
            {

            }
            return username;
        }

        //Has NunitTest
        public string ReadPasswordFromCredentialsFile()
        {
            string password = null;
            string path = importantInfo.Path;
            string fileName = importantInfo.fileName;
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + path);
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, fileName);
            var sr = new StreamReader(newFilePath);

            try
            {
                sr.ReadLine();
                string line = sr.ReadLine();
                password = line;
                sr.Close();
            }
            catch (Exception ex)
            {

            }
            return password;

        }

        //Cannot be tested
        public void DeleteSavedCredentialsFiles()
        {
           
            var credentialPath = (importantInfo.crdPath);
            var usernamePath = (importantInfo.uidPath);

            File.Delete(credentialPath);
            File.Delete(usernamePath);
        }

        //Cannot be tested
        public bool CheckIfCredentialsFileExist()
        {
            if (File.Exists(importantInfo.crdPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cannot be tested
        public void InsertUsernameAndPasswordIntoDB(string username,string password, string email)
        {
            connection.InsertUsernameAndPasswordIntoDB(username,password, email);
        }

        //Has NunitTest
        public bool CheckIfUsernameExists(string username)
        {
            bool check = connection.CheckIfUsernameExists(username);
            return check;
        }

        //Has NunitTest
        public bool CheckCharacterNameExistForUser(string characterName)
        {
            string username = ReadUsernameFromUsernameFile();
            int id = connection.SelectUserIdFromDB(username);
            bool check = connection.CheckCharacterNameExistForUser(characterName, id);
            return check;
        }

        //Has NunitTest
        public bool CheckUserCredentials(string username, string password)
        {
            bool checkCred = connection.CheckUserCredentials(username, password);
            return checkCred;
            
        }

        public bool CheckIfTextBoxOnlyNumbers(string textBoxText)
        {
            bool chk = false;

            if (Int32.TryParse(textBoxText, out int value))
            {
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }
    }
}