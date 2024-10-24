#include <map>
#include <string>
#include <iostream>
//#include <functional>
using namespace std;
class Ticker;
typedef void (Ticker::* func_ptr)(int v);
class Ticker
{
public:
    map<string, func_ptr> FunctionMap;
    int m_quantity_deals_on_bar;
    void SetQuantityDealsOnBar(int value) {
        cout << "calling func SetQuantityDealsOnBar" << endl;
        m_quantity_deals_on_bar = value;
    }
    Ticker() {
        m_quantity_deals_on_bar = 0;
        FunctionMap["Max_deal_bar_m_ord"] = &Ticker::SetQuantityDealsOnBar;
    }
    void SetValue(const string& name_var, int value_var) {
        auto it = FunctionMap.find(name_var);
        if (it != FunctionMap.end()) {
            (this->*(it->second))(value_var);
        }
    }
    void PrintObj();
};

class Tickers : public Ticker
{
private:
    static int count;
    Ticker* m_obj_arr[5];
public:
    Tickers() {}

    void AddObj(Ticker* obj);

    void PrintObj(int idx);

    Ticker* GetObj(int idx);
};
