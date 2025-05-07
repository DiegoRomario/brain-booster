namespace primeagen
{
    public class MaxHeap
    {
        private readonly List<int> data;

        public MaxHeap()
        {
            data = [];
        }

        public int Length
        {
            get { return data.Count; }
        }

        public void Insert(int value)
        {
            data.Add(value);
            HeapifyUp(Length - 1);
        }

        public int Delete()
        {
            if (Length == 0) return -1;

            int outValue = data[0];
            if (Length == 1)
            {
                data.RemoveAt(0);
                return outValue;
            }
            else
            {
                data[0] = data[Length - 1];
                data.RemoveAt(Length - 1);
                HeapifyDown(0);
                return outValue;
            }
        }

        private void HeapifyDown(int idx)
        {
            Stack<int> stack = new();
            stack.Push(idx);

            while (stack.Count > 0)
            {
                int currIdx = stack.Pop();
                if (currIdx >= Length) return;

                int leftIdx = LeftChildIdx(currIdx);
                if (leftIdx >= Length) return;

                int rightIdx = RightChildIdx(currIdx);

                int currVal = data[currIdx];
                int leftVal = data[leftIdx];
                int rightVal = (rightIdx < Length) ? data[rightIdx] : int.MinValue;

                int maxIdx = (rightVal > leftVal) ? rightIdx : leftIdx;
                int maxVal = data[maxIdx];

                if (currVal < maxVal)
                {
                    SwapIdx(currIdx, maxIdx);
                    stack.Push(maxIdx);
                }
            }
        }

        private void HeapifyUp(int idx)
        {
            Stack<int> stack = new();
            stack.Push(idx);

            while (stack.Count > 0)
            {
                int currIdx = stack.Pop();
                if (currIdx == 0) return;

                int currVal = data[currIdx];
                int parIdx = ParentIdx(currIdx);
                int parVal = data[parIdx];

                if (parVal < currVal)
                {
                    SwapIdx(parIdx, currIdx);
                    stack.Push(parIdx);
                }
            }
        }

        private void SwapIdx(int idxA, int idxB)
        {
            (data[idxB], data[idxA]) = (data[idxA], data[idxB]);
        }

        private static int ParentIdx(int idx)
        {
            return (idx - 1) / 2;
        }

        private static int LeftChildIdx(int idx)
        {
            return idx * 2 + 1;
        }

        private static int RightChildIdx(int idx)
        {
            return idx * 2 + 2;
        }
    }
}
