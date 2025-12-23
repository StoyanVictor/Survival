namespace Project.CodeBase.Gameplay.Player {
    public interface IInteractable {
        public bool CheckForInteract();
        public void Interact();
        
        public void ShowHideOutline(bool outlineState);
        
    }
}