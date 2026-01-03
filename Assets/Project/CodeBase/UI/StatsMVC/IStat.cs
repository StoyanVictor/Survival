namespace Project.CodeBase.UI.StatsMVC {
    public interface IStat {
        public float Stat {set; get;}
        public void Increase(float value);
        public void Decrease(float value);
    }
}