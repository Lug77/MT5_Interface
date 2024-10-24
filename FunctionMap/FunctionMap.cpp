#include <iostream>
#include <string>
#include "func.h"
using namespace std;

Ticker* get_obj(Tickers obj, string name_var, string& name_param) {
    cout << "calling get_obj" << endl;
    int pos = name_var.find("row");
    cout << "pos = " << pos << endl;
    int idx_obj;
    if (pos != -1) {
        string idx_obj_str = name_var.substr(pos + 4);
        name_param = name_var.substr(0, pos - 1);
        cout << "idx_obj_str = " << idx_obj_str << endl;
        idx_obj = stoi(idx_obj_str);
        return obj.GetObj(idx_obj);
    }
    else return NULL;
}

void set_param_obj(Ticker* obj, string name_param, int value_param) {
    if (name_param == "Max_deal_bar_m_ord")
        //obj->m_quantity_deals_on_bar = value_param;
        //obj->SetQuantityDealsOnBar(value_param);
        obj->SetValue(name_param, value_param);
}

int main() {
    Tickers obj_arr;
    for (int i = 0; i < 5; i++)
    {
        Ticker* obj = new Ticker;
        obj_arr.AddObj(obj);
    }
    for (int i = 0; i < 5; i++)
    {
        obj_arr.PrintObj(i);
    }
    string name_var = "Max_deal_bar_m_ord_row_2";
    int value_var = 10;
    string name_param = "";
    Ticker* need_obj = get_obj(obj_arr, name_var, name_param);
    need_obj->PrintObj();
    cout << "name_param " << name_param << endl;
    set_param_obj(need_obj, name_param, value_var);
    need_obj->PrintObj();
}
