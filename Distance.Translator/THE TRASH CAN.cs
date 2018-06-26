// Here is all the code that eventually got commented out (mainly test/debug procedures)


// From "Patches/MainMenuLogic/Start.cs | Postfix()"
/*
                CurrentPlugin.Log.Warning("Listing all UIExButton components in scene :");
                foreach (UIExButton element in FindObjectsOfType<UIExButton>())
                {
                    CurrentPlugin.Log.Warning("  - " + element.name + " : \"" + element.GetType().FullName + "\"");
                    foreach (Component comp in element.GetComponentsInChildren<MonoBehaviour>())
                    {
                        CurrentPlugin.Log.Warning("    - " + comp.name + " : \"" + comp.GetType().FullName + "\"");
                    }
                }

                CurrentPlugin.Log.Warning("");
                CurrentPlugin.Log.Warning("Listing all UILabel text :");

                List<UIExButton> Buttons = new List<UIExButton>();
                foreach (UIExButton element in FindObjectsOfType<UIExButton>())
                {
                    if (element.HasComponent<UILabel>())
                    {
                        CurrentPlugin.Log.Warning("  - " + element.GetComponent<UILabel>().text);
                    }

                }
*/
