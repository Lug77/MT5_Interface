#include "MyForm1.h"
#include "MyForm2.h"
using namespace System;
using namespace System::Windows::Forms;

[STAThreadAttribute]

int main() {
	//вызываем стат методы класса
	Application::SetCompatibleTextRenderingDefault(false);
	Application::EnableVisualStyles();
	int use_form = 2;
	if (use_form == 1)
		Application::Run(gcnew MaBotHedging::MyForm1());
	else
		Application::Run(gcnew MaBotHedging::MyForm2());
}
