using Matrimony.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Matrimony.ViewModels
{
    public class DataManager
    {
        FileOperation Operation = new FileOperation();

        public bool WriteData(string FilePath, List<Profile> Profiles)
        {
            bool breturn = false;            
            List<Profile> ListItems = new List<Profile>();

            try
            {
                string json = JsonConvert.SerializeObject(Profiles);
                Operation.WriteFile(FilePath, json);
                breturn = true;
            }
            catch (Exception ex)
            {

            }
            return breturn;
        }

        public List<Profile> ReadData(string FilePath, List<Profile> Profiles)
        {            
            List<Profile> ListItems = new List<Profile>();

            try
            {
                string strResult = Operation.ReadFile(FilePath);
                ListItems = JsonConvert.DeserializeObject<List<Profile>>(strResult);
            }
            catch (Exception ex)
            {

            }
            return ListItems;
        }

    }

    public class FileOperation
    {
        public string ReadFile(string FilePath)
        {
            string strReturnData = string.Empty;
            try
            {
                if (File.Exists(FilePath))
                {
                    FileStream oFileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    using (StreamReader oReader = new StreamReader(oFileStream))
                    {
                        strReturnData = oReader.ReadToEnd();
                        try
                        {
                            byte[] byteValRecDetl = Convert.FromBase64String(strReturnData);
                            strReturnData = UTF8Encoding.UTF8.GetString(byteValRecDetl);
                        }
                        catch (Exception oExp)
                        {

                        }
                        oFileStream.Close();
                        oFileStream.Dispose();
                    }
                    if (strReturnData.Length < 10 && FilePath.ToLower().Contains(".dat"))
                    {
                        strReturnData = "FileReadFalse";
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return strReturnData;
        }

        public bool WriteFile(string FilePath, string Content)
        {

            try
            {
                if (File.Exists(FilePath))
                {
                    File.WriteAllText(FilePath, Content);
                    return true;
                }
                else
                {
                    File.Create(FilePath);
                    File.WriteAllText(FilePath, Content);
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public bool DeleteFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                return true;
            }
            return false;
        }

    }
}
