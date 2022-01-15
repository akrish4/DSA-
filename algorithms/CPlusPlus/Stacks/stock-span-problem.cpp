/*The stock span problem is a financial problem where we have a series of n daily price quotes for a stock and we need to calculate span of stock’s price for all n days.*/
/*The span Si of the stock’s price on a given day i is defined as the maximum number of consecutive days just before the given day, for which the price of the stock on the current day is less than its price on the given day.*/
// C++ linear time solution for stock span problem

#include <bits/stdc++.h>
using namespace std;

// A stack based efficient method to calculate
// stock span values
void calculateSpan(const vector<int> price, const int priceSize,vector<int>& stockSpan)
{
    // Create a stack and push index of first
    // element to it
    stack<int> spanStack;
    spanStack.push(0);

    // Span value of first element is always 1
    stockSpan.push_back(1);

    // Calculate span values for rest of the elements
    for (int priceIt = 1; priceIt < priceSize; priceIt++) {
        // Pop elements from stack while stack is not
        // empty and top of stack is smaller than
        // price[i]
        while (!spanStack.empty() && price[spanStack.top()] < price[priceIt])
            spanStack.pop();

        // If stack becomes empty, then price[i] is
        // greater than all elements on left of it,
        // i.e., price[0], price[1], ..price[i-1].  Else
        // price[i] is greater than elements after
        // top of stack
        stockSpan.push_back( (spanStack.empty()) ? (priceIt + 1) : (priceIt - spanStack.top()) );

        // Push this element to stack
        spanStack.push(priceIt);
    }
}

// A utility function to print elements of array
void printArray(const vector<int>& arr,const int arrSize)
{
    for (int arrIt = 0; arrIt < arrSize; arrIt++)
        cout << arr[arrIt] << " ";
}

vector<int> getPrice()
{
    vector<int> price;
    int priceSize;
    //Enter the size of price
    cin>>priceSize;
    for(int sizeIt = 0 ; sizeIt < priceSize ; sizeIt++)
     {
         int priceEntry;
         cin>>priceEntry;
         price.push_back(priceEntry);
     }
     return price;
}

// Driver program to test above function
int main()
{
    // Fill the span values in array stockSpan[]
    vector<int> stockSpan;
    calculateSpan(getPrice(), getPrice().size(), stockSpan);

    // print the calculated span values
    printArray(stockSpan, getPrice().size());

    return 0;
}
