using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using UnityEngine;

namespace Distance.Translator
{
    public static class PrintData
    {
        public static void PrintGameobject(Spectrum.API.Logging.Logger LOG, GameObject gameobject)
        {
            int count = 0; // Just to avoid getting in an infinite loop
            LOG.Error("Displaying hierarchy of an object. This can take some time!");
            LOG.Warning("Displaying hierarchy of : " + gameobject.name + "(" + gameobject.GetType().FullName.ToString() + ")");
            foreach (Component comp in gameobject.GetComponents<MonoBehaviour>())
            {
                if (!(comp.GetType().FullName.ToString() == gameobject.GetType().FullName.ToString())) // Forgot this check before (messed things up)
                {
                    PrintComponent(LOG, comp, 1);
                }
                count += 1;
                if (count > 5)
                {
                    break;
                }
            }
        }

        public static void PrintComponent(Spectrum.API.Logging.Logger LOG, Component component)
        {
            LOG.Error("Displaying hierarchy of an object. This can take some time!");
            LOG.Warning("Displaying hierarchy of : " + component.name + "(" + component.GetType().FullName.ToString() + ")");
            PrintComponent(LOG, component, 1);
        }

        private static void PrintComponent(Spectrum.API.Logging.Logger LOG, Component component,int indentation)
        {
            StringBuilder indent;
            foreach (Component comp in component.GetComponents<MonoBehaviour>())
            {
                indent = new StringBuilder();
                indent.Append(' ',indentation * 2);
                LOG.Warning(indent.ToString() + "- " + component.name + "(" + component.GetType().FullName.ToString() + ")");
                if (indentation < 10) // Forgot this check before (messed things up)
                {
                    if (!(comp.GetType().FullName.ToString() == component.GetType().FullName.ToString())) // Forgot this check before (messed things up)
                    {
                        PrintComponent(LOG, comp, indentation + 1);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
