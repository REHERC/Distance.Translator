using UnityEngine;

namespace Distance.Translator
{
    class TrackmogrifyMenu : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Trackmogrify Menu";

        public void Run()
        {
            if (GameObject.Find("TrackmogrifyInputMenu/Panel(16:9)/Create a Profile Input") != null)
            {
                GameObject.Find("TrackmogrifyInputMenu/Panel(16:9)/Create a Profile Input/UILabel - Message").GetComponent<UILabel>().text = Language.TRACKMOGRIFY_SEED;
                GameObject.Find("TrackmogrifyInputMenu/Panel(16:9)/Create a Profile Input/RecentSeedsPanel/UILabel - Recent Seeds Header").GetComponent<UILabel>().text = Language.TRACKMOGRIFY_RECENT;
                GameObject.Find("TrackmogrifyInputMenu/Panel(16:9)/Create a Profile Input/PopularSeedsPanel/UILabel - Popular Seeds Header").GetComponent<UILabel>().text = Language.TRACKMOGRIFY_TOPRATED;

                CanRun = false;
            }
        }
    }
}