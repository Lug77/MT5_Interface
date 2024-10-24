#include <iostream>
#include "func.h"
using namespace std;

int Tickers::count = 0;

void Tickers::AddObj(Ticker* obj) {
	m_obj_arr[count] = obj;
	count++;
}

void Tickers::PrintObj(int idx) {
	cout << "idx obj " << idx << " param " << m_obj_arr[idx]->m_quantity_deals_on_bar << " adr = " << m_obj_arr[idx] << endl;
}

void Ticker::PrintObj() {
	cout << "param Ticker obj " << this->m_quantity_deals_on_bar << " adr = " << this << endl;
}

/*void Ticker::SetQuantityDealsOnBar(int value=0) {
  cout << "calling func SetQuantityDealsOnBar" << endl;
  m_quantity_deals_on_bar = value;
}*/

Ticker* Tickers::GetObj(int idx) {
	return m_obj_arr[idx];
}