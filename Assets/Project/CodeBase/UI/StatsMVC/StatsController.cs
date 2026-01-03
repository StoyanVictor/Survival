using Project.CodeBase.Gameplay.Player;

namespace Project.CodeBase.UI.StatsMVC {
    public class StatsController {
        
        private StatsView _statsView;
        
        private StatsModel _statsModel;

        public StatsModel GetModel => _statsModel;

        public StatsController(StatsView view, PlayerData playerData) {
            _statsModel = new StatsModel(new HealthStat(playerData.GetMaxHealth),
                new SatietyStat(playerData.GetMaxSatiety),new TemperatureStat(playerData.GetMaxTemperature));
            _statsView = view;
            view.Init(playerData.GetMaxHealth,playerData.GetMaxSatiety,playerData.GetMaxTemperature);
            Bind(view);
        }
        
        private void Bind(StatsView view) {
            _statsModel.OnHealthChanged += view.ChangeHealthStat;
            _statsModel.OnAppetiteChanges += view.ChangeSatietyStat;
            _statsModel.OnTemperatureChanged += view.ChangeTemperatureStat;
        }
    }
}