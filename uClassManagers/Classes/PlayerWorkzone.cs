using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerWorkzone")]
    public class PlayerWorkzoneClass
    {
        public PlayerWorkzone playerWorkzone { get; private set; }
        public PlayerWorkzoneClass(PlayerWorkzone c_PlayerWorkzone) => playerWorkzone = c_PlayerWorkzone;

        [ScriptProperty("snapTransform")]
        public float SnapTransform => playerWorkzone.snapTransform;

        [ScriptProperty("snapRotation")]
        public float SnapRotation => playerWorkzone.snapRotation;

        [ScriptProperty("isBuilding")]
        public bool IsBuilding
        {
            get => playerWorkzone.isBuilding;
            set => playerWorkzone.isBuilding = value;
        }

        [ScriptProperty("dragMode")]
        public string DragMode
        {
            get => playerWorkzone.dragMode.ToString();
            set
            {
                EDragMode? dragMode = EnumTool.dragModes.GetEnum(value);
                if (dragMode == null) return;
                playerWorkzone.dragMode = dragMode.Value;
            }
        }

        [ScriptProperty("dragCoordinate")]
        public string DragCoordinate
        {
            get => playerWorkzone.dragCoordinate.ToString();
            set
            {
                EDragCoordinate? dragCoordinate = EnumTool.dragCoordinates.GetEnum(value);
                if (dragCoordinate == null) return;
                playerWorkzone.dragCoordinate = dragCoordinate.Value;
            }
        }

        [ScriptFunction("addSelection")]
        public void AddSelection(TransformClass select)
        {
            playerWorkzone.addSelection(select.transform);
        }

        [ScriptFunction("applySelection")]
        public void ApplySelection()
        {
            playerWorkzone.applySelection();
        }

        [ScriptFunction("containsSelection")]
        public bool ContainsSelection(TransformClass select)
        {
            return playerWorkzone.containsSelection(select.transform);
        }

        [ScriptFunction("pointSelection")]
        public void PointSelection()
        {
            playerWorkzone.pointSelection();
        }

        [ScriptFunction("removeSelection")]
        public void RemoveSelection(TransformClass select)
        {
            playerWorkzone.removeSelection(select.transform);
        }
    }
}
