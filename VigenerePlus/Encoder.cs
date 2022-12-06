using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenerePlus
{
    /// <summary>
    /// 加密类
    /// </summary>
    internal class Encoder
    {
        //明文
        public string PlainText { get; set; }
        //密文
        public string Cypher { get; set; }  
        //密钥
        public string Key { get; set; } 

        //进行加密
        public void Encode()
        {
            int numkey;
            //用listnum来存储key的整数形式
            List<int> listnum = new List<int>();
            for (int i = 0; i < Key.Length; i++)
            {
                numkey = Key[i] - 'a';
                listnum.Add(numkey);
            }
            for (int i = 0; i < PlainText.Length; i++)
            {
                //明文字母转换为整数形式
                int numplain = PlainText[i] - 'a';
                //计算密文字幕的整数形式
                int n = (i % Key.Length);
                int numcipher = numplain + listnum[n];
                //密文转换为字母形式
                Cypher += Convert.ToChar(numcipher + 'a');
            }
        }
    }
}
