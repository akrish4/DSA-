#include <stdio.h>
#include <math.h>

int jumpSearch(int arr[], int n, int x) {
    int step = sqrt(n);
    int prev = 0;
    
    while (arr[(int)fmin(step, n) - 1] < x) {
        prev = step;
        step += sqrt(n);
        if (prev >= n)
            return -1;
    }
    
    while (arr[prev] < x) {
        prev++;
        if (prev == fmin(step, n))
            return -1;
    }
    
    if (arr[prev] == x)
        return prev;
    
    return -1;
}

int main() {
    int arr[100], n, target;
    
    printf("Enter the number of elements in the array: ");
    scanf("%d", &n);

    printf("Enter the elements of the array in sorted order:\n");
    for (int i = 0; i < n; i++) {
        scanf("%d", &arr[i]);
    }

    printf("Enter the target value to search for: ");
    scanf("%d", &target);

    int index = jumpSearch(arr, n, target);
    if (index != -1)
        printf("Element %d is present at index %d.\n", target, index);
    else
        printf("Element %d is not present in the array.\n", target);
    
    return 0;
}
