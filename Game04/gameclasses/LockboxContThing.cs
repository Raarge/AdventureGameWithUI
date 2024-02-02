using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    [Serializable]
    public class LockboxContThing : ContainerThing
    {
        private bool _locked;
        private bool _pickable;
        private int _pickDiff;
        private int _lockLvl;
        private bool _empty;
        
       

        public LockboxContThing(string aName, string aDescription, bool isTakeable, bool isMoveable, bool IsOpenable, bool open, ThingList tl, bool aLocked, bool aPickable, 
            int aPickDiff, int aLockLvl, bool aEmpty) : 
            base(aName, aDescription, isTakeable, isMoveable, IsOpenable, open ,tl) 
        {
            _locked = aLocked;
            _pickable = aPickable;
            _pickDiff = aPickDiff;
            _lockLvl = aLockLvl;
            _empty = aEmpty;
            
        }

        public void Lock()
        {
            _locked = true;
        }

        public void Unlock()
        {
            _locked = false;
        }

        public void IsPickable()
        {
            _pickable = true;
        }

        public void NotPickable()
        {
            _pickable = false;
        }

        public void Empty()
        {
            _empty = true;
        }

        public void NotEmpty()
        {
            _empty = false;
        }

        public bool IsLocked
        {
            get => _locked;
            set => _locked = value;
        }

        public bool Pickable
        {
            get => _pickable;
            set => _pickable = value;
        }

        public int PickDiff
        {
            get => _pickDiff; 
            set => _pickDiff = value;
        }

        public int LockLvl
        {
            get => _lockLvl; 
            set => _lockLvl = value;
        }

        public bool IsEmpty
        {
            get => _empty;
            set => _empty = value;
        }

    }
}
