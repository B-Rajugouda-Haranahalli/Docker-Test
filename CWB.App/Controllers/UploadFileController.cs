using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CWB.App.Controllers
{
    public class UploadFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFileToFtp(IFormFile uploadedFile)
        {
            string ftpUrl = "/files/";
            string ftpFullPath = ftpUrl + uploadedFile.FileName;
            //byte[] fileBytes =Convert.to(uploadedFile);

            // Write the byte array to the file
            using (var stream = new FileStream(ftpFullPath, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(stream);
            }
            //System.IO.File.WriteAllBytes(ftpFullPath, fileBytes);
            //await SaveFileToDisk(uploadedFile, ftpFullPath);
            return RedirectToAction("Index");
        }





















        //    [HttpPost]
        //public async Task<IActionResult> UploadFileToFtp(IFormFile uploadedFile)
        //{
        //    if (uploadedFile != null && uploadedFile.Length > 0)
        //    {
        //        // FTP Server details
        //        string ftpUrl = "/home/vsftpd/myuser/";  // Use localhost as the FTP server is in the same Docker network
        //        string ftpUsername = "myuser";
        //        string ftpPassword = "mypassword";
        //        //string uniqueFileName = Guid.NewGuid().ToString() + "_" + uploadedFile.FileName;

        //        string ftpFullPath = ftpUrl + uploadedFile.FileName;

        //        // Create FTP request
        //        //FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpFullPath);
        //        //request.Method = WebRequestMethods.Ftp.UploadFile;
        //        //request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
        //        //request.UsePassive = true; // or false
        //        //request.UseBinary = true;
        //        //request.EnableSsl = false;
                
        //        try
        //        {
        //            // Create FTP request
        //            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpFullPath);
        //            //request.Method = WebRequestMethods.Ftp.UploadFile;
        //            //request.Credentials = new NetworkCredential(ftpUsername,ftpPassword);
        //            //request.UsePassive = true;
        //            //// or false, depending on server configuration
        //            //request.UseBinary = true;
        //            //request.EnableSsl = false; // adjust if needed

        //            //using (var fileStream = uploadedFile.OpenReadStream())
        //            //using (var ftpStream = request.GetRequestStream())
        //            //{
        //            //    await fileStream.CopyToAsync(ftpStream);
        //            //}

        //            return Ok("File uploaded successfully to FTP server!");
        //        }
        //        catch (WebException ex)
        //        {
        //            // Handle WebException specifically
        //            if (ex.Status == WebExceptionStatus.ConnectFailure)
        //            {
        //                // Handle connection failure (firewall, network, etc.)
        //                return BadRequest("Unable to connect to the FTP server. Please check network connectivity or firewall settings.");
        //            }
        //            else
        //            {
        //                // Handle other WebException types (e.g., authentication failure)
        //                return BadRequest("Error uploading file to FTP server: " + ex.Message);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle unexpected exceptions
        //            return BadRequest("An unexpected error occurred: " + ex.Message);
        //        }

        //        ViewBag.Message = "File uploaded successfully to FTP server!";
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Please select a file to upload.";
        //    }
        //    //if (uploadedFile != null && uploadedFile.Length > 0)
        //    //{
        //    //    // FTP Server details 
        //    //    string ftpHost = "ftp://172.23.0.1"; // This should be the address of your FTP server
        //    //    string ftpUsername = "myuser";
        //    //    string ftpPassword = "5VpWQo4cyfscmk0K";
        //    //    var uniqueFileName = Guid.NewGuid().ToString() + "_" + uploadedFile.FileName;

        //    //    // Create an instance of FtpClient
        //    //    var client = new FtpClient(ftpHost, ftpUsername, ftpPassword);

        //    //    try
        //    //    {
        //    //        // Connect to the FTP server
        //    //        client.Connect();

        //    //        // Ensure the upload directory exists
        //    //        if (! client.DirectoryExists("/uploads"))
        //    //        {
        //    //            client.CreateDirectory("/uploads");
        //    //        }

        //    //        // Upload the file
        //    //        using (var fileStream = uploadedFile.OpenReadStream())
        //    //        {
        //    //            client.UploadFile(fileStream.ToString(), $"/uploads/{uniqueFileName}");
        //    //        }

        //    //        // Disconnect from the FTP server
        //    //        client.Disconnect();

        //    //        ViewBag.Message = "File uploaded successfully to FTP server!";
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        // Handle exceptions (e.g., connection issues, file access issues)
        //    //        ViewBag.Message = $"An error occurred: {ex.Message}";
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    ViewBag.Message = "Please select a file to upload.";
        //    //}

        //    return RedirectToAction("Index");
        //}
    }
}
