namespace ArrayCRUD
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray() : base()
        {
        }

        public override int this[int index]
        {
            get => base[index];
            set
            {
                if (!VerifyIfSortedAtInsertAndSetElement(index, value))
                {
                    return;
                }

                base[index] = value;
            }
        }

        public bool VerifyIfSortedAtAdd(int element)
        {
            return element >= base[Count - 1];
        }

        public bool VerifyIfSortedAtInsertAndSetElement(int index, int element)
        {
            if ((index == 0 && element <= base[index + 1]) || (index == Count && element >= base[index - 1]))
            {
                return true;
            }

            if (element >= base[index - 1] && element <= base[index + 1])
            {
                return true;
            }

            return false;
        }

        public override void Add(int element)
        {
            if (Count == 0)
            {
                base.Add(element);
            }
            else if (VerifyIfSortedAtAdd(element))
            {
                base.Add(element);
            }
            else
            {
                base.Insert(FindRightPosition(element), element);
            }
        }

        public override void Insert(int index, int element)
        {
            if (!VerifyIfSortedAtInsertAndSetElement(index, element))
            {
                return;
            }

            base.Insert(index, element);
        }

        private int FindRightPosition(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (element <= base[i])
                {
                    return i;
                }
            }

            return Count + 1;
        }
    }
}
