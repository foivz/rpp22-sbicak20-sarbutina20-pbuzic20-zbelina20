﻿using PdfSharp.Pdf;
using PdfSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;
using PdfSharp.Drawing;
using EntitiesLayer.Entities;
using PdfSharp.Pdf.Advanced;
using System.Drawing;
using System.Windows.Forms;

namespace BusinessLogicLayer.PDF
{
    public static class GeneriranjePDF
    {      
        public static void SacuvajPDF(Racun racun, List<StavkaRacun> listaStavki = null)
        {
            //Create PDF Document
            PdfDocument document = new PdfDocument();
            //You will have to add Page in PDF Document
            PdfPage page = document.AddPage();
            page.Size = PageSize.A4;
            page.TrimMargins.Top = 0.5;
            page.TrimMargins.Right = 0.5;
            page.TrimMargins.Bottom = 0.5;
            page.TrimMargins.Left = 0.5;

            

            //pen
            XPen pen = new XPen(XColor.FromName("black"), 2.2);

            double x = 50; // width ---->
            double y = 85; // height gore/dolje

            //For drawing in PDF Page you will nedd XGraphics Object
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //For Test you will have to define font to be used
            XFont font = new XFont("Arial", 20, XFontStyle.BoldItalic);

            double ls = font.GetHeight();
            //Finally use XGraphics & font object to draw text in PDF Page
            //gfx.DrawString($"My First PDF Document", font, XBrushes.Black, new XRect(0, 0, 0, 0), XStringFormats.Center);
            //gfx.DrawString("My First PDF Documentkjhkhjkhj", font, XBrushes.Black, new XRect(0, 0, page.Width, 15), XStringFormats.CenterRight);
            // prvi dio racuna
            gfx.DrawString("ZMG Damir Bičak", font, XBrushes.Black, x, y);
            y += ls;
            font = new XFont("Arial", 12, XFontStyle.Bold);
            ls = font.GetHeight();
            gfx.DrawString("ZAŠTITA METALNE GALANTERIJE", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString("Sveti Ivan Zelina", font, XBrushes.Black, x, y);
            y += 20;
            //drugi dio racuna
            font = new XFont("Arial", 10, XFontStyle.Regular);
            ls = font.GetHeight();
            gfx.DrawString("NKD 2007:25.61 - OBRADA I PREVLAČENJE METALA", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString("OPĆI MEHANIČKI RADOVI", font, XBrushes.Black, x, y);
            y += ls + 3;
            //treci dio
            //poslodavac
            gfx.DrawString($"UPIS U OBRTNI REGISTAR: {racun.Poslodavac.UpisObrtniRegistar}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Br. OBRTNICE: {racun.Poslodavac.BrojObrtnice}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"OIB: {racun.Poslodavac.OIB}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Poslovnica: {racun.Poslodavac.Poslovnica}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Adresa: {racun.Poslodavac.Adresa}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Mjesto: 10380 {racun.Poslodavac.Mjesto}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Država: {racun.Poslodavac.Drzava}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Banka: {racun.Poslodavac.Banka}", font, XBrushes.Black, x, y);
            y = 203;
            //treci dio -- drugio dio, druga strana
            x += 150;
            gfx.DrawString($"TEL. {racun.Poslodavac.TEL_FAX}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"GSM. {racun.Poslodavac.BrojTelefona}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"TEL/FAX. {racun.Poslodavac.TEL_FAX}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Email: {racun.Poslodavac.Email}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Žiro račun: {racun.Poslodavac.IBAN}", font, XBrushes.Black, x, y);
            //telefone treba promijeniti
            y = 180;
            x += 190;
            gfx.DrawString("Prima", font, XBrushes.Black, x, y);
            y += 3;
            gfx.DrawLine(pen, new XPoint(x, y), new XPoint(x+160, y));
            y += 20;
            //klijent
            gfx.DrawString($"Naziv: {racun.Klijent.Naziv}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Adresa: {racun.Klijent.Adresa}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Mjesto: {racun.Klijent.Mjesto}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"OIB: {racun.Klijent.OIB}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawLine(pen, new XPoint(x, y), new XPoint(x + 160, y));
            y += 40;

            // cetvrti dio -- racun i stavke

            x = 50;
            font = new XFont("Arial", 10, XFontStyle.Bold);
            gfx.DrawString($"RAČUN BROJ: {racun.Racun_ID}", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString($"Stavke računa:", font, XBrushes.Black, x, y);
            x = 390;
            font = new XFont("Arial", 10, XFontStyle.Regular);
            gfx.DrawString($"Datum izdavanja: {racun.DatumIzdavanja.Value.ToShortDateString()}", font, XBrushes.Black, x, y);
            y -= ls;
            gfx.DrawString($"Vrijeme izdavanja: {racun.DatumIzdavanja.Value.ToShortTimeString()}", font, XBrushes.Black, x, y);
            y += ls;
            x = 50;
            y += ls - 3;
            gfx.DrawLine(pen, new XPoint(x, y), new XPoint(550, y));
            y += ls + 3;


            // stavke
            font = new XFont("Arial", 9, XFontStyle.Regular);
            gfx.DrawString($"r.b.", font, XBrushes.Black, x, y);
            // 5 stavki izemdu 50 i 550
            x += 24;
            gfx.DrawString($"Naziv usluge", font, XBrushes.Black, x, y);
            //x = 74
            x += 70;
            gfx.DrawString($"Naziv robe", font, XBrushes.Black, x, y);
            //x = 144
            x += 70;
            gfx.DrawString($"Jed. količina", font, XBrushes.Black, x, y);
            //x = 214
            x += 70;
            gfx.DrawString($"Datum izrade", font, XBrushes.Black, x, y);
            //x = 284
            x += 70;
            gfx.DrawString($"Količina(kg)", font, XBrushes.Black, x, y);
            //x = 354;
            x += 70;
            gfx.DrawString($"Jed. cijena/kg", font, XBrushes.Black, x, y);
            //x = 424
            x += 70;
            gfx.DrawString($"Ukupna cijena", font, XBrushes.Black, x, y);
            //x = 494


            x = 50;
            y += ls + 5;
            StavkaRacun stavka = new StavkaRacun();
            for (int i = 1; i <= 10; i++)
            {
                gfx.DrawString($"{i}.", font, XBrushes.Black, x, y);
                // popunavanje izmedu
                if (i <= listaStavki.Count && listaStavki != null)
                {
                    stavka = listaStavki[i - 1];

                    x += 24;
                    gfx.DrawString($"{stavka.Usluga.Naziv}", font, XBrushes.Black, x, y);
                    //x = 74
                    x += 70;
                    gfx.DrawString($"{stavka.Roba.Naziv}", font, XBrushes.Black, x, y);
                    //x = 144
                    x += 70;
                    gfx.DrawString($"{stavka.KolikoRobePoJedinici}", font, XBrushes.Black, x, y);
                    //x = 214
                    x += 70;
                    gfx.DrawString($"{stavka.DatumIzrade.Value.ToShortDateString()}", font, XBrushes.Black, x, y);
                    //x = 284
                    x += 70;
                    gfx.DrawString($"{stavka.KolicinaRobe}", font, XBrushes.Black, x, y);
                    //x = 354;
                    x += 70;
                    gfx.DrawString($"{stavka.JedinicnaCijena}", font, XBrushes.Black, x, y);
                    //x = 424
                    x += 70;
                    gfx.DrawString($"{stavka.UkupnaCijenaStavke}", font, XBrushes.Black, x, y);
                    //x = 494
                }
                //kraj
                y += ls + 5;
                x = 50;
            }
            font = new XFont("Arial", 10, XFontStyle.Bold);
            y -= ls;
            gfx.DrawLine(pen, new XPoint(x, y), new XPoint(550, y));
            x = 424;
            y += ls;
            gfx.DrawString($"Ukupno:", font, XBrushes.Black, x, y);
            x = 494;
            gfx.DrawString($"{racun.UkupnoStavke}", font, XBrushes.Black, x, y);
            y += ls + 3;
            x = 424;
            gfx.DrawString($"PDV(25%):", font, XBrushes.Black, x, y);
            x = 494;
            gfx.DrawString($"{racun.PDV}", font, XBrushes.Black, x, y);
            y += ls + 3;
            x = 424;
            gfx.DrawString($"Ukupan iznos:", font, XBrushes.Black, x, y);
            x = 494;
            gfx.DrawString($"{racun.UkupnaCijena}", font, XBrushes.Black, x, y);
            y += ls + 3;


            // peti dio -- kraj racuna, izdan u takvom obliku, fakturirao itd.


            string filename = "FirstPDFDocument.pdf";

            document.Save(filename);
            //Load PDF File for viewing
            Process.Start(filename);
        }
    }
}