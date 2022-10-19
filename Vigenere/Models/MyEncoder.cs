using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace MyEncoder
{
	public class Encoder
	{
		///明文
		public string Plaintext { get; set; }

		///密文
		public string Cipher { get; set; }

		///密钥
		public string Key { get; set; }

		///加密
		public void MyEncoder()
		{
			int numkey;
			//用listnum来存储key的整数形式
			List<int> listnum = new List<int>();
			for (int i = 0; i < Key.Length; i++)
			{
				numkey = Key[i] - 'a';
				listnum.Add(numkey);
			}
			for (int i = 0; i < Plaintext.Length; i++)
			{
				//明文字母转换为整数形式
				int numplain = Plaintext[i] - 'a';
				//计算密文字幕的整数形式
				int n = (i % Key.Length);
				int numcipher = numplain + listnum[n];
				//密文转换为字母形式
				Cipher += Convert.ToChar(numcipher + 'a');
			}

		}

	}
}


