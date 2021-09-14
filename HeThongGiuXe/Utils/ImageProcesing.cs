using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongGiuXe.Utils
{
    class ImageProcesing
    {
        static public void CaptureToImageFile(VideoCapture capture, string filePath)
        {
            Mat m = new Mat();
            capture.Retrieve(m);
            m.Save(filePath);
        }
    }
}
