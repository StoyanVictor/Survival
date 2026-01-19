using Project.CodeBase.Gameplay.Events;
using Project.CodeBase.Infrastructure;

namespace Project.CodeBase.UI.StatsMVC {
    public class SurvivalRulesCustomizer {

        private float _temperatureTicDamage = 1;
        private float _hungerTicDamage = 1;
        
        private StatsController _statsController;
        
        public SurvivalRulesCustomizer(StatsController statsController) {
            _statsController = statsController;
            _statsController.GetModel.OnTemperatureChanged += CheckTemperatureRules;
            _statsController.GetModel.OnAppetiteChanges += CheckSatietyRule;
            _statsController.GetModel.OnHealthChanged += CheckHealthRule;
        }
        
        private void CheckTemperatureRules(float temperature) {
            if (temperature <= 0) {
                //TODO и тут после урона и перерисовки UI должен произойти вызов шины событий типо Event-Смерти-Игрока
            }
            else if (temperature <= 30) {
                //EventBus.Raise(new ColdEnoughEvent(1));
                _statsController.GetModel.DecreaseHealth(_temperatureTicDamage);
                //TODO и тут после урона и перерисовки UI должен произойти вызов шины событий типо Event-Начала-Обморожения 
            }
            else
                return;
        }

        private void CheckSatietyRule(float satiety) {
            if (satiety <= 0) {
                _statsController.GetModel.DecreaseHealth(_hungerTicDamage);
                //TODO и тут после урона и перерисовки UI должен произойти вызов шины событий типо Event-Начала-Сильного-Голода 
            }
            else if (satiety <= 30) {
                //TODO и тут после урона и перерисовки UI должен произойти вызов шины событий типо Event-Начала-Голодания 
                //TODO ну после замедление игрока тут короче 
            }
            else
                return;
        }

        private void CheckHealthRule(float hp) {
            if(hp > 0)
                return;
            EventBus.Raise(new PlayerDiedEvent(Container.Instance.Timer.GetCurrentGameTime));
            //TODO и тут после урона и перерисовки UI должен произойти вызов шины событий типо Event-Смерти-Игрока
        }
    }
}