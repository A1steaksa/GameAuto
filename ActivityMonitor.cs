namespace GameAuto {
    public class ActivityMonitor {

        private List<Activity> activities = new List<Activity>();

        public void AddActivity( Activity activity ) {
            activities.Add( activity );
        }

        public void RemoveActivity( Activity activity ) {
            activities.Remove( activity );
        }

        public void Start() {

        }

    }
}