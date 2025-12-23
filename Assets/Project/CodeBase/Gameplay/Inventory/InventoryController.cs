using System;

namespace Project.CodeBase.Gameplay.Inventory {
    public class InventoryController {
    
        private InventoryModel _model;
        private InventoryView _view;

        public InventoryController(InventoryView view) {
            _model = new InventoryModel();
            _view = view;
            _model.OnItemAdded += inventory => _view.RedrawInventoryView(inventory);
        }
        public void AddItem(InventoryItemData data) => _model.AddItem(data);
    }
}