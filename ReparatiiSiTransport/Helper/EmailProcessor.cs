﻿using ReparatiiSiTransport.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace ReparatiiSiTransport.Helper
{
    public class EmailProcessor
    {
        public bool SendEmail(EmailModel email)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                MailMessage message = new MailMessage();
                email.ToEmailAddress = "office@reparatiisitransport.ro";

                MailAddress fromAddress = new MailAddress(email.ToEmailAddress, email.Name);

                smtpClient.Host = "smtp.gmail.com";

                smtpClient.Port = 587;

                NetworkCredential info = new NetworkCredential("office.reparatiisitransport@gmail.com", "Mobatehnic2018!");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = info;
                smtpClient.EnableSsl = true;

                //From address will be given as a MailAddress Object
                message.From = fromAddress;

                // To address collection of MailAddress
                message.To.Add(email.ToEmailAddress);
                message.Subject = email.Subject;
                message.IsBodyHtml = true;

                // Message body content
                string ss_body = string.Format(@"<html><body><table width='100%' bgcolor='#ffffff' border='0' cellpadding='10' cellspacing='0'>
<tbody>
      <tr>
				<td align='center' valign='top'>
						<table border='0' cellpadding='0' cellspacing='0' width='100%' >
							<tbody>
              <tr>
			<td valign='top' style='background-color:#0c224f;padding:20px;'>
				  <h2 style='color:white;font-family:Arial, Helvetica, sans-serif;'>Cerere programare noua</h2>
            </td>
		</tr>
        <tr style='padding:5px;background-color:white;'>
            <div style='padding:20px;font-size:14px;background-color:white;border:10px solid #0c224f;'>
  	            <div style='color:black;margin-left:10px'><b>Nume client</b>: {1}</div>
                <div style='color:black;margin-left:10px'><b>Adresa email client</b>: {2}</div>
                <div style='color:black;margin-left:10px'><b>Mesaj</b>: {3}</div>
                <div style='color:black;margin-left:10px'><b>Numar telefon</b>: {4}</div>
            </div>
        </tr>
        <tr style='padding:5px;background-color:#0c224f;'>
            <img height='70' width='110' align='right' src='http://test.reparatiisitransport.ro/logo-footer.png' />
        </tr>
    </tbody></table>
    </body></html>", email.Subject, email.Name,email.FromEmailAddress,email.Message,email.PhoneNumber);
                message.Body = ss_body;
                // Send SMTP mail
                smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}