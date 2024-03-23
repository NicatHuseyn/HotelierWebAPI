using HotelierProject.Application.Services.FileServices;
using HotelierProject.Infrastructure.Operations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Infrastructure.Services.FileServices
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        public FileService(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
                await fileStream.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<string> FileRenameAsync(string path, string fileName)
        {
            await Task.Run(async () =>
            {
                string extension = Path.GetExtension(fileName);
                string oldName = Path.GetFileNameWithoutExtension(fileName);
                string newFileName = $"{NameOperation.CharacterRegulatory(fileName)}{extension}";

                if (File.Exists($"{path}\\{newFileName}"))
                    await FileRenameAsync(path,newFileName);
            });

            return "";
        }

        public async Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = Path.Combine(_hostEnvironment.WebRootPath,path);

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);


            List<(string fileName, string path)> datas = new();
            List<bool> results = new();

            foreach (IFormFile file in files)
            {
                //string fileNewName = await FileRenameAsync(file.FileName);

                //bool result = await CopyFileAsync($"{uploadPath}\\{fileNewName}", file);
                //datas.Add((fileNewName,$"{uploadPath}\\{fileNewName}"));
                //results.Add(result);
            }

            if (results.TrueForAll(r => r.Equals(true)))
                return datas;



            return null;
        }

        

    }
}
