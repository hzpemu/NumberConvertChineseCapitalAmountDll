using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace hzpctrllib
{
	/// <summary>
	/// UserControl1 ��ժҪ˵����
	/// </summary>
	public class UserControl1 : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		public string output;
	

		public UserControl1(string input)
		{
            // �õ����� Windows.Forms ���������������ġ�
			InitializeComponent();
			// TODO: �� InitComponent ���ú�����κγ�ʼ��
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
				else if (a.Substring(a.Length-1,1)=="1") b="Ҽ";
				else if (a.Substring(a.Length-1,1)=="2") b="��";
				else if (a.Substring(a.Length-1,1)=="3") b="��";
				else if (a.Substring(a.Length-1,1)=="4") b="��";
				else if (a.Substring(a.Length-1,1)=="5") b="��";
				else if (a.Substring(a.Length-1,1)=="6") b="½";
				else if (a.Substring(a.Length-1,1)=="7") b="��";
				else if (a.Substring(a.Length-1,1)=="8") b="��";
				else if (a.Substring(a.Length-1,1)=="9") b="��";
			}
			if(a.Length>=2)
			{ 
				if(a.Substring(a.Length-2,1)=="0") {if(a.Substring(a.Length-4,1)!="0"){if((a.Substring(a.Length-1,1)!="0")&&(a.Substring(a.Length-3,1)!="0"))b="��"+b;}}
				else if (a.Substring(a.Length-2,1)=="1") b="Ҽʰ"+b;
				else if (a.Substring(a.Length-2,1)=="2") b="��ʰ"+b;
				else if (a.Substring(a.Length-2,1)=="3") b="��ʰ"+b;
				else if (a.Substring(a.Length-2,1)=="4") b="��ʰ"+b;
				else if (a.Substring(a.Length-2,1)=="5") b="��ʰ"+b;
				else if (a.Substring(a.Length-2,1)=="6") b="½ʰ"+b;
				else if (a.Substring(a.Length-2,1)=="7") b="��ʰ"+b;
				else if (a.Substring(a.Length-2,1)=="8") b="��ʰ"+b;
				else if (a.Substring(a.Length-2,1)=="9") b="��ʰ"+b;
			}
			if(a.Length>=3)
			{ 
				if(a.Substring(a.Length-3,1)=="0"){	if(a.Substring(a.Length-4,1)!="0"){if((a.Substring(a.Length-1,1)!="0")||(a.Substring(a.Length-2,1)!="0")){b="��"+b;} }}
				else if (a.Substring(a.Length-3,1)=="1") b="Ҽ��"+b;
				else if (a.Substring(a.Length-3,1)=="2") b="����"+b;
				else if (a.Substring(a.Length-3,1)=="3") b="����"+b;
				else if (a.Substring(a.Length-3,1)=="4") b="����"+b;
				else if (a.Substring(a.Length-3,1)=="5") b="���"+b;
				else if (a.Substring(a.Length-3,1)=="6") b="½��"+b;
				else if (a.Substring(a.Length-3,1)=="7") b="���"+b;
				else if (a.Substring(a.Length-3,1)=="8") b="�ư�"+b;
				else if (a.Substring(a.Length-3,1)=="9") b="����"+b;
			}
			if(a.Length>=4)
			{ 
				if(a.Substring(a.Length-4,1)=="0"){}// {if(a.Substring(a.Length-3,1)=="0"){}  else {b="��"+b;} }
				else if (a.Substring(a.Length-4,1)=="1") b="ҼǪ"+b;
				else if (a.Substring(a.Length-4,1)=="2") b="��Ǫ"+b;
				else if (a.Substring(a.Length-4,1)=="3") b="��Ǫ"+b;
				else if (a.Substring(a.Length-4,1)=="4") b="��Ǫ"+b;
				else if (a.Substring(a.Length-4,1)=="5") b="��Ǫ"+b;
				else if (a.Substring(a.Length-4,1)=="6") b="½Ǫ"+b;
				else if (a.Substring(a.Length-4,1)=="7") b="��Ǫ"+b;
				else if (a.Substring(a.Length-4,1)=="8") b="��Ǫ"+b;
				else if (a.Substring(a.Length-4,1)=="9") b="��Ǫ"+b;
			}
			if(a.Length>=5)
			{ 
				if(a.Substring(a.Length-5,1)=="0") b="��"+b;
				else if (a.Substring(a.Length-5,1)=="1") b="Ҽ��"+b;
				else if (a.Substring(a.Length-5,1)=="2") b="����"+b;
				else if (a.Substring(a.Length-5,1)=="3") b="����"+b;
				else if (a.Substring(a.Length-5,1)=="4") b="����"+b;
				else if (a.Substring(a.Length-5,1)=="5") b="����"+b;
				else if (a.Substring(a.Length-5,1)=="6") b="½��"+b;
				else if (a.Substring(a.Length-5,1)=="7") b="����"+b;
				else if (a.Substring(a.Length-5,1)=="8") b="����"+b;
				else if (a.Substring(a.Length-5,1)=="9") b="����"+b;
			}	
			if(a.Length>=6)
			{ 
				if(a.Substring(a.Length-6,1)=="0") {if(a.Substring(a.Length-8,1)!="0"){if((a.Substring(a.Length-5,1)!="0")&&(a.Substring(a.Length-7,1)!="0"))b="��"+b;}}
				else if (a.Substring(a.Length-6,1)=="1") b="Ҽʰ"+b;
				else if (a.Substring(a.Length-6,1)=="2") b="��ʰ"+b;
				else if (a.Substring(a.Length-6,1)=="3") b="��ʰ"+b;
				else if (a.Substring(a.Length-6,1)=="4") b="��ʰ"+b;
				else if (a.Substring(a.Length-6,1)=="5") b="��ʰ"+b;
				else if (a.Substring(a.Length-6,1)=="6") b="½ʰ"+b;
				else if (a.Substring(a.Length-6,1)=="7") b="��ʰ"+b;
				else if (a.Substring(a.Length-6,1)=="8") b="��ʰ"+b;
				else if (a.Substring(a.Length-6,1)=="9") b="��ʰ"+b;
			}
			if(a.Length>=7)
			{ 
				if(a.Substring(a.Length-7,1)=="0"){	if(a.Substring(a.Length-8,1)!="0"){if(((a.Substring(a.Length-5,1)!="0"))||((a.Substring(a.Length-6,1)!="0")))b="��"+b;} }
			else if (a.Substring(a.Length-7,1)=="1") b="Ҽ��"+b;
			else if (a.Substring(a.Length-7,1)=="2") b="����"+b;
			else if (a.Substring(a.Length-7,1)=="3") b="����"+b;
			else if (a.Substring(a.Length-7,1)=="4") b="����"+b;
			else if (a.Substring(a.Length-7,1)=="5") b="���"+b;
			else if (a.Substring(a.Length-7,1)=="6") b="½��"+b;
			else if (a.Substring(a.Length-7,1)=="7") b="���"+b;
			else if (a.Substring(a.Length-7,1)=="8") b="�ư�"+b;
			else if (a.Substring(a.Length-7,1)=="9") b="����"+b;
			}
			if(a.Length>=8)
			{ 
				if(a.Substring(a.Length-8,1)=="0"){}// {if(a.Substring(a.Length-7,1)=="0"){}else {b="��"+b;} }
				else if (a.Substring(a.Length-8,1)=="1") b="ҼǪ"+b;
				else if (a.Substring(a.Length-8,1)=="2") b="��Ǫ"+b;
				else if (a.Substring(a.Length-8,1)=="3") b="��Ǫ"+b;
				else if (a.Substring(a.Length-8,1)=="4") b="��Ǫ"+b;
				else if (a.Substring(a.Length-8,1)=="5") b="��Ǫ"+b;
				else if (a.Substring(a.Length-8,1)=="6") b="½Ǫ"+b;
				else if (a.Substring(a.Length-8,1)=="7") b="��Ǫ"+b;
				else if (a.Substring(a.Length-8,1)=="8") b="��Ǫ"+b;
				else if (a.Substring(a.Length-8,1)=="9") b="��Ǫ"+b;
			}
			if(a.Length>=9)
			{ 
				if(a.Substring(a.Length-9,1)=="0") b="��"+b;
				else if (a.Substring(a.Length-9,1)=="1") b="Ҽ��"+b;
				else if (a.Substring(a.Length-9,1)=="2") b="����"+b;
				else if (a.Substring(a.Length-9,1)=="3") b="����"+b;
				else if (a.Substring(a.Length-9,1)=="4") b="����"+b;
				else if (a.Substring(a.Length-9,1)=="5") b="����"+b;
				else if (a.Substring(a.Length-9,1)=="6") b="½��"+b;
				else if (a.Substring(a.Length-9,1)=="7") b="����"+b;
				else if (a.Substring(a.Length-9,1)=="8") b="����"+b;
				else if (a.Substring(a.Length-9,1)=="9") b="����"+b;
			}
			if(a.Length>=10)
			{ 
				if(a.Substring(a.Length-10,1)=="0")  {if(a.Substring(a.Length-12,1)!="0"){if((a.Substring(a.Length-9,1)!="0")&&(a.Substring(a.Length-11,1)!="0"))b="��"+b;}}
				else if (a.Substring(a.Length-10,1)=="1") b="Ҽʰ"+b;
				else if (a.Substring(a.Length-10,1)=="2") b="��ʰ"+b;
				else if (a.Substring(a.Length-10,1)=="3") b="��ʰ"+b;
				else if (a.Substring(a.Length-10,1)=="4") b="��ʰ"+b;
				else if (a.Substring(a.Length-10,1)=="5") b="��ʰ"+b;
				else if (a.Substring(a.Length-10,1)=="6") b="½ʰ"+b;
				else if (a.Substring(a.Length-10,1)=="7") b="��ʰ"+b;
				else if (a.Substring(a.Length-10,1)=="8") b="��ʰ"+b;
				else if (a.Substring(a.Length-10,1)=="9") b="��ʰ"+b;
			}
			if(a.Length>=11)
			{ 
				if(a.Substring(a.Length-11,1)=="0")	{	if(a.Substring(a.Length-12,1)!="0"){if(((a.Substring(a.Length-9,1)!="0"))||((a.Substring(a.Length-10,1)!="0")))b="��"+b;} }
				else if (a.Substring(a.Length-11,1)=="1") b="Ҽ��"+b;
				else if (a.Substring(a.Length-11,1)=="2") b="����"+b;
				else if (a.Substring(a.Length-11,1)=="3") b="����"+b;
				else if (a.Substring(a.Length-11,1)=="4") b="����"+b;
				else if (a.Substring(a.Length-11,1)=="5") b="���"+b;
				else if (a.Substring(a.Length-11,1)=="6") b="½��"+b;
				else if (a.Substring(a.Length-11,1)=="7") b="���"+b;
				else if (a.Substring(a.Length-11,1)=="8") b="�ư�"+b;
				else if (a.Substring(a.Length-11,1)=="9") b="����"+b;
			}
				if(a.Length>=12)
				{ 
					if(a.Substring(a.Length-12,1)=="0") { }
					else if (a.Substring(a.Length-12,1)=="1") b="ҼǪ"+b;
					else if (a.Substring(a.Length-12,1)=="2") b="��Ǫ"+b;
					else if (a.Substring(a.Length-12,1)=="3") b="��Ǫ"+b;
					else if (a.Substring(a.Length-12,1)=="4") b="��Ǫ"+b;
					else if (a.Substring(a.Length-12,1)=="5") b="��Ǫ"+b;
					else if (a.Substring(a.Length-12,1)=="6") b="½Ǫ"+b;
					else if (a.Substring(a.Length-12,1)=="7") b="��Ǫ"+b;
					else if (a.Substring(a.Length-12,1)=="8") b="��Ǫ"+b;
					else if (a.Substring(a.Length-12,1)=="9") b="��Ǫ"+b;
				}
				if(a1.Length>=1)
				{
					if(a1.Substring(0,1)=="0") c="Ԫ";
					else if (a1.Substring(0,1)=="1") c="ԪҼ��";
					else if (a1.Substring(0,1)=="2") c="Ԫ����";
					else if (a1.Substring(0,1)=="3") c="Ԫ����";
					else if (a1.Substring(0,1)=="4") c="Ԫ����";
					else if (a1.Substring(0,1)=="5") c="Ԫ���";
					else if (a1.Substring(0,1)=="6") c="Ԫ½��";
					else if (a1.Substring(0,1)=="7") c="Ԫ���";
					else if (a1.Substring(0,1)=="8") c="Ԫ�ƽ�";
					else if (a1.Substring(0,1)=="9") c="Ԫ����";
				}
				if(a1.Length>=2)
				{
					if(a1.Substring(1,1)=="0") c=c+"";
					else if (a1.Substring(1,1)=="1") c=c+"Ҽ��";
					else if (a1.Substring(1,1)=="2") c=c+"����";
					else if (a1.Substring(1,1)=="3") c=c+"����";
					else if (a1.Substring(1,1)=="4") c=c+"����";
					else if (a1.Substring(1,1)=="5") c=c+"���";
					else if (a1.Substring(1,1)=="6") c=c+"½��";
					else if (a1.Substring(1,1)=="7") c=c+"���";
					else if (a1.Substring(1,1)=="8") c=c+"�Ʒ�";
					else if (a1.Substring(1,1)=="9") c=c+"����";
				}
				this.output=b+c;
				return;
			

			}


		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region �����������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭�� 
		/// �޸Ĵ˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
