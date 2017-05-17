using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using iTextSharp.text;
using iTextSharp.text.pdf;

using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using WebApplication2.Models;
using WebApplication2.Business;

using System.Web.Configuration;
using System.Configuration;

namespace ModAdministrative.Controllers
{
    public class PdfController : Controller
    {
        // GET: Pdf
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeneratePdf()
        {

            RoomBusiness rb = new RoomBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());
            List<Room> rooms = rb.getRoomsState().ToList();

            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=" + "PDFfile.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            string value = "Hello";
            foreach(var i in rooms)
            {
                value = i.NameRoom.ToString();
                break;
            }
            Response.BinaryWrite(GetPDF(rooms));
            Response.End();

            return RedirectToAction("AvailablesRoom", "Room");

        }

        public byte[] GetPDF(List<Room> rooms)
        {
            byte[] bPDF = null;

            MemoryStream ms = new MemoryStream();

            // 1: create object of a itextsharp document class  
            Document doc = new Document(PageSize.A4, 25, 25, 25, 25);

            // 2: we create a itextsharp pdfwriter that listens to the document and directs a XML-stream to a file  
            PdfWriter oPdfWriter = PdfWriter.GetInstance(doc, ms);

            doc.Open();

            Paragraph pTitle = new Paragraph(new Phrase("Zante Hotel", FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
            pTitle.Alignment = Element.ALIGN_CENTER;

            Paragraph pReport = new Paragraph(new Phrase("Reporte: Estado Actual de las habitaciones del Zante Hotel", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL)));
            pReport.Alignment = Element.ALIGN_JUSTIFIED;

            Paragraph pDate = new Paragraph(new Phrase("Fecha de Reporte: " + DateTime.Now.ToString("d"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL)));
            pDate.Alignment = Element.ALIGN_JUSTIFIED;

            Paragraph pSpace = new Paragraph(" ");

            string path = Server.MapPath("~/Content/Images/xfavicon-apple.png.pagespeed.ic.vIS_cO_Xol.png");
            Image waterMaker = Image.GetInstance(path);
            waterMaker.SetAbsolutePosition(500, 750);
            waterMaker.ScalePercent(20);

            PdfPTable informationTable = new PdfPTable(2);
            informationTable.WidthPercentage = 80;

            PdfPCell clNameRoom = new PdfPCell(new Phrase("Nombre Habitación", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clNameRoom.BorderWidth = 0.75f;

            PdfPCell clState = new PdfPCell(new Phrase("Estado Habitación", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clState.BorderWidth = 0.75f;

            informationTable.AddCell(clNameRoom);
            informationTable.AddCell(clState);

            foreach (var i in rooms)
            {

                clNameRoom = new PdfPCell(new Phrase(i.NameRoom, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                clNameRoom.BorderWidth = 0.75f;

                string state;
                if(i.AvailabilityRoom == true)
                {
                    state = "Disponible";
                } else
                {
                    state = "Ocupada";
                }

                clState = new PdfPCell(new Phrase(state, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                clState.BorderWidth = 0.75f;

                informationTable.AddCell(clNameRoom);
                informationTable.AddCell(clState);

            }

            doc.Add(pTitle);
            doc.Add(pReport);
            doc.Add(pDate);
            doc.Add(waterMaker);
            doc.Add(pSpace);
            doc.Add(informationTable);

            doc.Close();

            bPDF = ms.ToArray();

            return bPDF;
        }

    }
}