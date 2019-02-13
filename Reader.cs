using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using System.Drawing;
namespace OCR_Project
{
    class Reader
    {
        public string Read(Bitmap bmp)
        {
            TesseractEngine ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);

            var text = ocr.Process(bmp);
            return text.GetText();
        }

    }
}
