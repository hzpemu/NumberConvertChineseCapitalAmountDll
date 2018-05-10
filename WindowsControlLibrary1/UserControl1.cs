using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace hzpctrllib
{
	/// <summary>
	/// UserControl1 的摘要说明。
	/// </summary>
	public class UserControl1 : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		public string output;
	

		public UserControl1(string input)
		{
            // 该调用是 Windows.Forms 窗体设计器所必需的。
			InitializeComponent();
			// TODO: 在 InitComponent 调用后添加任何初始化
			string a;
			string a1;
			string b;
			string c;
			a="";
			a1="";
			b="";
			c="";
			int result=input.IndexOf(".",0);
			if(result>0){a=input.Substring(0,input.IndexOf(".",0));a1=input.Substring(input.IndexOf(".",0)+1,input.Length-1-input.IndexOf(".",0));}
			else{a=input;}			
			if(a.Length>=1)
			{ 
				if(a.Substring(a.Length-1,1)=="0") b="";
				else if (a.Substring(a.Length-1,1)=="1") b="壹";
				else if (a.Substring(a.Length-1,1)=="2") b="贰";
				else if (a.Substring(a.Length-1,1)=="3") b="叁";
				else if (a.Substring(a.Length-1,1)=="4") b="肆";
				else if (a.Substring(a.Length-1,1)=="5") b="伍";
				else if (a.Substring(a.Length-1,1)=="6") b="陆";
				else if (a.Substring(a.Length-1,1)=="7") b="柒";
				else if (a.Substring(a.Length-1,1)=="8") b="捌";
				else if (a.Substring(a.Length-1,1)=="9") b="玖";
			}
			if(a.Length>=2)
			{ 
				if(a.Substring(a.Length-2,1)=="0") {if(a.Substring(a.Length-4,1)!="0"){if((a.Substring(a.Length-1,1)!="0")&&(a.Substring(a.Length-3,1)!="0"))b="零"+b;}}
				else if (a.Substring(a.Length-2,1)=="1") b="壹拾"+b;
				else if (a.Substring(a.Length-2,1)=="2") b="贰拾"+b;
				else if (a.Substring(a.Length-2,1)=="3") b="叁拾"+b;
				else if (a.Substring(a.Length-2,1)=="4") b="肆拾"+b;
				else if (a.Substring(a.Length-2,1)=="5") b="伍拾"+b;
				else if (a.Substring(a.Length-2,1)=="6") b="陆拾"+b;
				else if (a.Substring(a.Length-2,1)=="7") b="柒拾"+b;
				else if (a.Substring(a.Length-2,1)=="8") b="捌拾"+b;
				else if (a.Substring(a.Length-2,1)=="9") b="玖拾"+b;
			}
			if(a.Length>=3)
			{ 
				if(a.Substring(a.Length-3,1)=="0"){	if(a.Substring(a.Length-4,1)!="0"){if((a.Substring(a.Length-1,1)!="0")||(a.Substring(a.Length-2,1)!="0")){b="零"+b;} }}
				else if (a.Substring(a.Length-3,1)=="1") b="壹佰"+b;
				else if (a.Substring(a.Length-3,1)=="2") b="贰佰"+b;
				else if (a.Substring(a.Length-3,1)=="3") b="叁佰"+b;
				else if (a.Substring(a.Length-3,1)=="4") b="肆佰"+b;
				else if (a.Substring(a.Length-3,1)=="5") b="伍佰"+b;
				else if (a.Substring(a.Length-3,1)=="6") b="陆佰"+b;
				else if (a.Substring(a.Length-3,1)=="7") b="柒佰"+b;
				else if (a.Substring(a.Length-3,1)=="8") b="捌佰"+b;
				else if (a.Substring(a.Length-3,1)=="9") b="玖佰"+b;
			}
			if(a.Length>=4)
			{ 
				if(a.Substring(a.Length-4,1)=="0"){}// {if(a.Substring(a.Length-3,1)=="0"){}  else {b="零"+b;} }
				else if (a.Substring(a.Length-4,1)=="1") b="壹仟"+b;
				else if (a.Substring(a.Length-4,1)=="2") b="贰仟"+b;
				else if (a.Substring(a.Length-4,1)=="3") b="叁仟"+b;
				else if (a.Substring(a.Length-4,1)=="4") b="肆仟"+b;
				else if (a.Substring(a.Length-4,1)=="5") b="伍仟"+b;
				else if (a.Substring(a.Length-4,1)=="6") b="陆仟"+b;
				else if (a.Substring(a.Length-4,1)=="7") b="柒仟"+b;
				else if (a.Substring(a.Length-4,1)=="8") b="捌仟"+b;
				else if (a.Substring(a.Length-4,1)=="9") b="玖仟"+b;
			}
			if(a.Length>=5)
			{ 
				if(a.Substring(a.Length-5,1)=="0") b="万"+b;
				else if (a.Substring(a.Length-5,1)=="1") b="壹万"+b;
				else if (a.Substring(a.Length-5,1)=="2") b="贰万"+b;
				else if (a.Substring(a.Length-5,1)=="3") b="叁万"+b;
				else if (a.Substring(a.Length-5,1)=="4") b="肆万"+b;
				else if (a.Substring(a.Length-5,1)=="5") b="伍万"+b;
				else if (a.Substring(a.Length-5,1)=="6") b="陆万"+b;
				else if (a.Substring(a.Length-5,1)=="7") b="柒万"+b;
				else if (a.Substring(a.Length-5,1)=="8") b="捌万"+b;
				else if (a.Substring(a.Length-5,1)=="9") b="玖万"+b;
			}	
			if(a.Length>=6)
			{ 
				if(a.Substring(a.Length-6,1)=="0") {if(a.Substring(a.Length-8,1)!="0"){if((a.Substring(a.Length-5,1)!="0")&&(a.Substring(a.Length-7,1)!="0"))b="零"+b;}}
				else if (a.Substring(a.Length-6,1)=="1") b="壹拾"+b;
				else if (a.Substring(a.Length-6,1)=="2") b="贰拾"+b;
				else if (a.Substring(a.Length-6,1)=="3") b="叁拾"+b;
				else if (a.Substring(a.Length-6,1)=="4") b="肆拾"+b;
				else if (a.Substring(a.Length-6,1)=="5") b="伍拾"+b;
				else if (a.Substring(a.Length-6,1)=="6") b="陆拾"+b;
				else if (a.Substring(a.Length-6,1)=="7") b="柒拾"+b;
				else if (a.Substring(a.Length-6,1)=="8") b="捌拾"+b;
				else if (a.Substring(a.Length-6,1)=="9") b="玖拾"+b;
			}
			if(a.Length>=7)
			{ 
				if(a.Substring(a.Length-7,1)=="0"){	if(a.Substring(a.Length-8,1)!="0"){if(((a.Substring(a.Length-5,1)!="0"))||((a.Substring(a.Length-6,1)!="0")))b="零"+b;} }
			else if (a.Substring(a.Length-7,1)=="1") b="壹佰"+b;
			else if (a.Substring(a.Length-7,1)=="2") b="贰佰"+b;
			else if (a.Substring(a.Length-7,1)=="3") b="叁佰"+b;
			else if (a.Substring(a.Length-7,1)=="4") b="肆佰"+b;
			else if (a.Substring(a.Length-7,1)=="5") b="伍佰"+b;
			else if (a.Substring(a.Length-7,1)=="6") b="陆佰"+b;
			else if (a.Substring(a.Length-7,1)=="7") b="柒佰"+b;
			else if (a.Substring(a.Length-7,1)=="8") b="捌佰"+b;
			else if (a.Substring(a.Length-7,1)=="9") b="玖佰"+b;
			}
			if(a.Length>=8)
			{ 
				if(a.Substring(a.Length-8,1)=="0"){}// {if(a.Substring(a.Length-7,1)=="0"){}else {b="零"+b;} }
				else if (a.Substring(a.Length-8,1)=="1") b="壹仟"+b;
				else if (a.Substring(a.Length-8,1)=="2") b="贰仟"+b;
				else if (a.Substring(a.Length-8,1)=="3") b="叁仟"+b;
				else if (a.Substring(a.Length-8,1)=="4") b="肆仟"+b;
				else if (a.Substring(a.Length-8,1)=="5") b="伍仟"+b;
				else if (a.Substring(a.Length-8,1)=="6") b="陆仟"+b;
				else if (a.Substring(a.Length-8,1)=="7") b="柒仟"+b;
				else if (a.Substring(a.Length-8,1)=="8") b="捌仟"+b;
				else if (a.Substring(a.Length-8,1)=="9") b="玖仟"+b;
			}
			if(a.Length>=9)
			{ 
				if(a.Substring(a.Length-9,1)=="0") b="亿"+b;
				else if (a.Substring(a.Length-9,1)=="1") b="壹亿"+b;
				else if (a.Substring(a.Length-9,1)=="2") b="贰亿"+b;
				else if (a.Substring(a.Length-9,1)=="3") b="叁亿"+b;
				else if (a.Substring(a.Length-9,1)=="4") b="肆亿"+b;
				else if (a.Substring(a.Length-9,1)=="5") b="伍亿"+b;
				else if (a.Substring(a.Length-9,1)=="6") b="陆亿"+b;
				else if (a.Substring(a.Length-9,1)=="7") b="柒亿"+b;
				else if (a.Substring(a.Length-9,1)=="8") b="捌亿"+b;
				else if (a.Substring(a.Length-9,1)=="9") b="玖亿"+b;
			}
			if(a.Length>=10)
			{ 
				if(a.Substring(a.Length-10,1)=="0")  {if(a.Substring(a.Length-12,1)!="0"){if((a.Substring(a.Length-9,1)!="0")&&(a.Substring(a.Length-11,1)!="0"))b="零"+b;}}
				else if (a.Substring(a.Length-10,1)=="1") b="壹拾"+b;
				else if (a.Substring(a.Length-10,1)=="2") b="贰拾"+b;
				else if (a.Substring(a.Length-10,1)=="3") b="叁拾"+b;
				else if (a.Substring(a.Length-10,1)=="4") b="肆拾"+b;
				else if (a.Substring(a.Length-10,1)=="5") b="伍拾"+b;
				else if (a.Substring(a.Length-10,1)=="6") b="陆拾"+b;
				else if (a.Substring(a.Length-10,1)=="7") b="柒拾"+b;
				else if (a.Substring(a.Length-10,1)=="8") b="捌拾"+b;
				else if (a.Substring(a.Length-10,1)=="9") b="玖拾"+b;
			}
			if(a.Length>=11)
			{ 
				if(a.Substring(a.Length-11,1)=="0")	{	if(a.Substring(a.Length-12,1)!="0"){if(((a.Substring(a.Length-9,1)!="0"))||((a.Substring(a.Length-10,1)!="0")))b="零"+b;} }
				else if (a.Substring(a.Length-11,1)=="1") b="壹佰"+b;
				else if (a.Substring(a.Length-11,1)=="2") b="贰佰"+b;
				else if (a.Substring(a.Length-11,1)=="3") b="叁佰"+b;
				else if (a.Substring(a.Length-11,1)=="4") b="肆佰"+b;
				else if (a.Substring(a.Length-11,1)=="5") b="伍佰"+b;
				else if (a.Substring(a.Length-11,1)=="6") b="陆佰"+b;
				else if (a.Substring(a.Length-11,1)=="7") b="柒佰"+b;
				else if (a.Substring(a.Length-11,1)=="8") b="捌佰"+b;
				else if (a.Substring(a.Length-11,1)=="9") b="玖佰"+b;
			}
				if(a.Length>=12)
				{ 
					if(a.Substring(a.Length-12,1)=="0") { }
					else if (a.Substring(a.Length-12,1)=="1") b="壹仟"+b;
					else if (a.Substring(a.Length-12,1)=="2") b="贰仟"+b;
					else if (a.Substring(a.Length-12,1)=="3") b="叁仟"+b;
					else if (a.Substring(a.Length-12,1)=="4") b="肆仟"+b;
					else if (a.Substring(a.Length-12,1)=="5") b="伍仟"+b;
					else if (a.Substring(a.Length-12,1)=="6") b="陆仟"+b;
					else if (a.Substring(a.Length-12,1)=="7") b="柒仟"+b;
					else if (a.Substring(a.Length-12,1)=="8") b="捌仟"+b;
					else if (a.Substring(a.Length-12,1)=="9") b="玖仟"+b;
				}
				if(a1.Length>=1)
				{
					if(a1.Substring(0,1)=="0") c="元";
					else if (a1.Substring(0,1)=="1") c="元壹角";
					else if (a1.Substring(0,1)=="2") c="元贰角";
					else if (a1.Substring(0,1)=="3") c="元叁角";
					else if (a1.Substring(0,1)=="4") c="元肆角";
					else if (a1.Substring(0,1)=="5") c="元伍角";
					else if (a1.Substring(0,1)=="6") c="元陆角";
					else if (a1.Substring(0,1)=="7") c="元柒角";
					else if (a1.Substring(0,1)=="8") c="元捌角";
					else if (a1.Substring(0,1)=="9") c="元玖角";
				}
				if(a1.Length>=2)
				{
					if(a1.Substring(1,1)=="0") c=c+"";
					else if (a1.Substring(1,1)=="1") c=c+"壹分";
					else if (a1.Substring(1,1)=="2") c=c+"贰分";
					else if (a1.Substring(1,1)=="3") c=c+"叁分";
					else if (a1.Substring(1,1)=="4") c=c+"肆分";
					else if (a1.Substring(1,1)=="5") c=c+"伍分";
					else if (a1.Substring(1,1)=="6") c=c+"陆分";
					else if (a1.Substring(1,1)=="7") c=c+"柒分";
					else if (a1.Substring(1,1)=="8") c=c+"捌分";
					else if (a1.Substring(1,1)=="9") c=c+"玖分";
				}
				this.output=b+c;
				return;
			

			}


		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region 组件设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器 
		/// 修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
