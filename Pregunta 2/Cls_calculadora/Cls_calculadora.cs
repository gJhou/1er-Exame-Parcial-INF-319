using System;
using System.Collections.Generic;
using System.Text;

namespace Cls_calculadora
{
    public class Cls_calculadora
    {
        public Boolean existePunto(String cadena)
        {
            Boolean resp = false;
            for (int x = 0; x < cadena.Length; x++)
            {

                if (cadena.Contains("."))
                {
                    resp = true;
                    return resp;
                }
            }
            return resp;
        }


        public String calculaRespuesta(String memoria1, String memoria2, String signo)
        {
            String resp="";
            double resul=0;
            if (signo.Equals("+"))
            {
                resul = (double.Parse(memoria1)) + (double.Parse(memoria2));
            }
            if (signo.Equals("-"))
            {
                resul = (double.Parse(memoria1)) - (double.Parse(memoria2));
            }
            if (signo.Equals("*"))
            {
                resul = (double.Parse(memoria1)) * (double.Parse(memoria2));
            }
            if (signo.Equals("/"))
            {
                resul = (double.Parse(memoria1)) / (double.Parse(memoria2));
            }
            resp = resul.ToString();


            return resp;
        }
    }
}
