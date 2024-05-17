//Write a function called `contains` that searches for a value in a nested object. It returns true if the object contains that value.

```javascript
var nestedObject = {
    data: {
        info: {
            stuff: {
                thing: {
                    moreStuff: {
                        magicNumber: 44
                    }
                }
            }
        }
    }
}

contains(nestedObject, 44) // true
contains(nestedObject, "foo") // false
```

// Solution
const contains = (object, checkValue) => {
    if (object == null || Object.keys(object).length === 0) {
        return false;
    }

    for (let [key, value] of Object.entries(object)) {
        if (key === checkValue || value === checkValue) {
            return true;
        }
        if (typeof value === 'object' && contains(value, checkValue)) {
            return true;
        }
    }

    return false;
};
