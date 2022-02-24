using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Linq;
namespace ImageFilters
{

    public class ImageOperations
    {
        public static byte GetMin(byte[] arr)
        {
            int i;

            // Initialize maximum element
            byte min = arr[0];

            for (i = 1; i < arr.Length; i++)
                if (arr[i] <  min && arr[i] != 0)
                    min = arr[i];

            return min;
        }

       public static byte GetMax(byte[] arr)
        {
            int i;
            byte max = arr[0];

            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }
        /// <summary>
        /// Open an image, convert it to gray scale and load it into 2D array of size (Height x Width)
        /// </summary>
        /// <param name="ImagePath">Image file path</param>
        /// <returns>2D array of gray values</returns>
        public static int originalHeight;
        public static int originalWidth;
        public static byte[,] OpenImage(string ImagePath)
        {
            Bitmap original_bm = new Bitmap(ImagePath);
            int Height = original_bm.Height;
            int Width = original_bm.Width;
            originalHeight = Height;
            originalWidth = Width;
            byte[,] Buffer = new byte[Height, Width];

            unsafe
            {
                BitmapData bmd = original_bm.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, original_bm.PixelFormat);
                int x, y;
                int nWidth = 0;
                bool Format32 = false;
                bool Format24 = false;
                bool Format8 = false;

                if (original_bm.PixelFormat == PixelFormat.Format24bppRgb)
                {
                    Format24 = true;
                    nWidth = Width * 3;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format32bppArgb || original_bm.PixelFormat == PixelFormat.Format32bppRgb || original_bm.PixelFormat == PixelFormat.Format32bppPArgb)
                {
                    Format32 = true;
                    nWidth = Width * 4;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    Format8 = true;
                    nWidth = Width;
                }
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (y = 0; y < Height; y++)
                {
                    for (x = 0; x < Width; x++)
                    {
                        if (Format8)
                        {
                            Buffer[y, x] = p[0];
                            p++;
                        }
                        else
                        {
                            Buffer[y, x] = (byte)((int)(p[0] + p[1] + p[2]) / 3);
                            if (Format24) p += 3;
                            else if (Format32) p += 4;
                        }
                    }
                    p += nOffset;
                }
                original_bm.UnlockBits(bmd);
            }

            return Buffer;
        }

        /// <summary>
        /// Get the height of the image 
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <returns>Image Height</returns>
            public static int GetHeight(byte[,] ImageMatrix)
            {
                return ImageMatrix.GetLength(0);
            }

            /// <summary>
            /// Get the width of the image 
            /// </summary>
            /// <param name="ImageMatrix">2D array that contains the image</param>
            /// <returns>Image Width</returns>
            public static int GetWidth(byte[,] ImageMatrix)
            {
                return ImageMatrix.GetLength(1);
            }

        /// <summary>
        /// Display the given image on the given PictureBox object
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <param name="PicBox">PictureBox object to display the image on it</param>
        public static void DisplayImage(byte[,] ImageMatrix, PictureBox PicBox)
        {
            // Create Image:
            //==============
            int Height = ImageMatrix.GetLength(0);
            int Width = ImageMatrix.GetLength(1);

            Bitmap ImageBMP = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);

            unsafe
            {
                BitmapData bmd = ImageBMP.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, ImageBMP.PixelFormat);
                int nWidth = 0;
                nWidth = Width * 3;
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        p[0] = p[1] = p[2] = ImageMatrix[i, j];
                        p += 3;
                    }

                    p += nOffset;
                }
                ImageBMP.UnlockBits(bmd);
            }
            PicBox.Image = ImageBMP;
        }
         public static byte[,] padding(byte[,] ImageMatrix)

        {
            byte[,] ArrayZeroPad = new byte[ImageMatrix.GetLength(0) + 2, ImageMatrix.GetLength(1) + 2];
            for (int x = 0; x < ImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < ImageMatrix.GetLength(1); y++)
                {
                    ArrayZeroPad[x + 1, y + 1] = ImageMatrix[x, y];
                }
            }
            return ArrayZeroPad;
        }
        // Partitioning and QuickSort function
        public static int Partition(byte[] Array, int p, int r)
        {
            byte x = Array[r];
            byte Temp;
            int i = p;
            for (int j = p; j < r; j++)
            {
                if (Array[j] <= x)
                {
                    Temp = Array[j];
                    Array[j] = Array[i];
                    Array[i++] = Temp;
                }
            }
            Temp = Array[i];
            Array[i] = Array[r];
            Array[r] = Temp;
            return i;
        }
        public static byte[] QuickSort(byte[] Array, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(Array, p, r);
                QuickSort(Array, p, q - 1);
                QuickSort(Array, q + 1, r);
            }
            return Array;
        }

        // CountingSort function

       public static Byte[] CountingSort(Byte[] arr) //array(n)
        {
            Byte[] freqArr = new Byte[256];
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                Byte index = arr[i];
                freqArr[index]++;
            }
            for (int i = 1; i < 256; i++)
            {
                freqArr[i] += freqArr[i - 1];
            }


            for (int i = 255; i > 0; i--)
            {
                freqArr[i] = freqArr[i - 1];
            }
            freqArr[0] = 0;


            Byte[] arranged = new Byte[size];

            for (int i = 0; i < size; i++)
            {
                Byte index = arr[i];
                Byte arrIndex = freqArr[index];
                arranged[arrIndex] = index;
                freqArr[index]++;
            }
            return arranged;
        }
      class Node
        {

            public int data;
            public Node left, right;
            public Node(int x)
            {
                data = x;
                left = right = null;
            }

            static int count = 0;
            static int deleteElement(byte[] arr,
                                int n,
                                int x)
            {

                // If x is last element,
                // nothing to do O(1)
                if (arr[n - 1] == x)
                    return (n - 1);

                // Start from rightmost
                // element and keep moving
                // elements one position ahead.
                byte prev = arr[n - 1];
                int i;
                //O(n)
                for (i = n - 2; i >= 0 &&
                        arr[i] != x; i--)
                {
                    byte curr = arr[i];
                    arr[i] = prev;
                    prev = curr;
                }

                // If element was
                // not found
                if (i < 0)
                    return 0;

                // Else move the next
                // element in place of x
                arr[i] = prev;

                return (n - 1);// new size of array
            }
            // Recursive function to 
            // insert an key into BST // logN
            public static Node insert(Node root,
                                      int x)
            {
                if (root == null)
                    return new Node(x);
                if (x < root.data)
                    root.left = insert(root.left, x);
                else if (x > root.data)
                    root.right = insert(root.right, x);
                //Console.WriteLine(root.data);
                return root;
            }
            public static Node kthSmallest(Node root,
                               int k)
            {
                // base case
                if (root == null)
                    return null;

                // search in left subtree
                Node left = kthSmallest(root.left, k);

                // if k'th smallest is found
                // in left subtree, return it
                if (left != null)
                {
                    // Console.WriteLine(left.data);
                    return left;
                }

                // if current element is
                // k'th smallest, return it
                count++;
                if (count == k)
                {
                    //Console.WriteLine(root.data);
                    return root;
                }

                // else search in right subtree
                return kthSmallest(root.right, k);
            }
            // best case O(H) H : height of tree
            // worst case O(N) N : Number of Nodes
            public static Node kthLargest(Node root,
                               int k)
            {
                // base case
                if (root == null)
                    return null;

                Node right = kthLargest(root.right, k);

                if (right != null)
                {
                    return right;
                }

                count++;
                if (count == k)
                {

                    return root;
                }
                // if array is small look all over the array
                return kthLargest(root.left, k);
            }
            public static int FindKthLargest(Node root,
                                        int k)
            {
                // Maintain an index to
                // count number of nodes
                // processed so far
                count = 0;

                Node res = kthLargest(root, k);

                if (res == null)
                {
                    return -1;
                }

                else
                    return res.data;
            }
            // returns node Data
            public static int FindKthSmallest(Node root,
                                    int k)
            {
                // Maintain an index to
                // count number of nodes
                // processed so far
                count = 0;

                Node res = kthSmallest(root, k);

                if (res == null)
                {
                    return -1;
                }

                else
                    return res.data;
            }
            public static byte[] KthExcluding(byte[] arr, int KValue)
            {
                Node rootOftree = null;
                int arraySize = arr.Length;
                //function to insert the elemnt in BST
                // n log n  
                foreach (int arrayindex in arr)
                {
                    rootOftree = insert(rootOftree, arrayindex);
                }
                int kSmallest;
                int klargest;
                kSmallest = FindKthSmallest(rootOftree, KValue); // best O(h) worst O(n)
                klargest = FindKthLargest(rootOftree, KValue);// best O(h) worst O(n)
                arraySize = deleteElement(arr, arraySize, kSmallest); //O(n)
                arraySize = deleteElement(arr, arraySize, klargest); // O(n)
                int len = arr.Length;
                Array.Resize(ref arr, len - 2); //O(n)
                return arr;
            }


        }

        // Alpha-TrimFilter function
                public static byte Filter1(byte[,] ImageMatrix, int x, int y, int Wmax, int Sort, int T)
        {
             byte[] window ;
            int ArrayLength = 0;
            int avg = 0;
            if(Wmax % 2 ==0)
            {
                window = new byte[(Wmax + 1) * (Wmax + 1)];
            }
            else
            {
                window = new byte[Wmax * Wmax];
            }
            
            int sum = 0;
            for (int i = 0; i < Wmax; i++)
            {
                for (int j = 0; j < Wmax; j++)
                {
                    window[ArrayLength] = ImageMatrix[x + i, y + j];
                    ArrayLength++;

                }
            }
            if (Sort == 2) {
                window =  CountingSort(window);
                  
                    }
            else if (Sort == 3){
                window = Node.KthExcluding(window,T);
          
            }

            for (int i = T; i < ArrayLength - (T); i++)
            {
                sum += window[i];
            }


            avg = (sum / (ArrayLength - (T*2)));
            return (byte)avg;
        }

         public static byte Filter2(byte[,] ImageMatrix, int x, int y, int W, int Wmax, int Sort)
    {
        byte[] window = new byte[W * W];
        
        int Index = 0;
        for (int i = x - (W/ 2); i <= x + (W / 2); i++)
        {
            for (int j = y - (W / 2); j <= y + (W / 2); j++)
            {
                if (i >= 0 && i < GetHeight(ImageMatrix) && j >= 0 && j < GetWidth(ImageMatrix))
                {
                    window[Index++] = ImageMatrix[i, j];
                }   
            }
        }
        int A1, A2, B1, B2;
        byte Max, Min, Med, Z;
        Z = ImageMatrix[x, y];
        Max = GetMax(window);
        Min = GetMin(window);
        if (Sort == 1) window = QuickSort(window, 0, Index - 1);
        else if (Sort == 2) window =  CountingSort(window);
        Min = window[0];
        Med = window[Index / 2];
        A1 = Med - Min;
        A2 = Max - Med;
            int indexcount = 2;

           if (Min == 0 && Med == 0)
                    {
                      Min = window[window.Length - (indexcount*indexcount)];
                      Med = window[window.Length - (indexcount * indexcount)/2];
                   }
        if (A1 > 0 && A2 > 0)
        {
            B1 = Z - Min;
            B2 = Max - Z;
            if (B1 > 0 && B2 > 0)
                return Z;
            else
            {
                if (W + 2 < Wmax)
                {
                    return Filter2(ImageMatrix, x, y, W + 2, Wmax, Sort);
                }
                else
                    return Med;
            }
        }
        else
        {
            return Med;
        }

    }
        ////
        public static byte[,] ImageFilter(byte[,] ImageMatrix, int Max_Size, int Sort, int filter, int trim)
        {
            bool alpha = true;  
            byte[,] ImageMatrix2 = ImageMatrix;
            for (int x = 0; x < originalHeight ; x++)
            {
                for (int y = 0; y < originalWidth; y++)
                {
                     if (filter == 1)
                    { 
                      if(alpha)
                        {
                            for (int z = 0; z < Max_Size/2; z++)
                            {
                                ImageMatrix = padding(ImageMatrix);
                            }
                            alpha = false;
                        }
                      ImageMatrix2[x, y] = Filter1(ImageMatrix, x, y, Max_Size, Sort, trim);
                      }
                    else if (filter == 2) { 
                   
                        ImageMatrix2[x,y] = Filter2(ImageMatrix, x, y, 3, Max_Size, Sort);
                    }
                }
            }

            return ImageMatrix2;
        }
    }
}
        
        
        
    

