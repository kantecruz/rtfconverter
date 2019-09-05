using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itenso.Sys.Test;
using NUnit.Framework;
using Itenso.Rtf.Interpreter;
using Itenso.Rtf.Model;
using Itenso.Rtf.Parser;
using Itenso.Rtf.Support;
using Itenso.Rtf.Converter.Text;
using Itenso.Rtf;
using System.IO;
using Itenso.Rtf.Converter.Html;
namespace ExampleRTFtoHtml
{
   
    public sealed class Convert : TestUnitBase
    {        
        public string CovnvertRtftoHtml(string rtf)
        {
            const RtfParserListenerLogger parserLogger = null;

            IRtfGroup rtfStructure = RtfParserTool.Parse(rtf, parserLogger);
            Assert.IsNotNull(rtfStructure);

            const RtfInterpreterListenerLogger interpreterLogger = null;

            RtfTextConverter textConverter = new RtfTextConverter();
            IRtfDocument rtfDocument = RtfInterpreterTool.BuildDoc(rtfStructure, textConverter, interpreterLogger);
            RtfHtmlConvertSettings htmlConvertSettings = new RtfHtmlConvertSettings();
            htmlConvertSettings.ConvertScope = RtfHtmlConvertScope.Content;
            RtfHtmlConverter htmlConverter = new RtfHtmlConverter(rtfDocument);
            string plainText = htmlConverter.Convert();
            plainText = plainText.Replace("@?]e1", "á").Replace("@?]e9", "é").Replace("@?]f3", "ó").Replace("@?]ed", "í").Replace("@?]c1", "á").Replace("@?]f1", "ñ").Replace("@?]fa", "ú"); //aqui reemplazamos para letras con acentos.
            return plainText;
        }

    } 
}
