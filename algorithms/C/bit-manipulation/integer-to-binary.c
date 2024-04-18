#include <stdio.h>

int integer_to_binary(int x){
    // Size of an int in bits (assuming 32 bits)
    int s = sizeof x * 8;
    int _x = 0;

    while(s--) {
        int bit = (x >> s) & 1; // Extract the least significant bit
        _x *= 10; // Shift the number left to make space for the new digit
        _x += bit; // Add the new digit to the number
    }

    return _x;
}

int main(){
    int number = 0;

    printf("Enter a number: ");
    scanf("%d", &number);

    printf("%d\n", integer_to_binary(number)); // Output the result

    return 0;
}