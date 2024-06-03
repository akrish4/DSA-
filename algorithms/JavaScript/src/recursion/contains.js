// Write a function called `contains` that searches for a value in a nested
// object.
// It returns true if the object contains that value.

''`javascript
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
```;

// Solution
const contains = (object, checkValue) => {
  if (object == null || Object.keys(object).length === 0) {
    return false;
  }

  for (const [key, value] of Object.entries(object)) {
    if (key === checkValue || value === checkValue) {
      return true;
    }
    // eslint-disable-next-line no-unused-vars
    if (typeof value === 'object' && contains(value, checkValue)) {
      return true;
    }
  }

  return false;
};

// Note
// Time Complexity: 𝑂(𝑛) where n is the total number of key-value pairs
// in the object.
// Space Complexity: 𝑂(𝑑) where d is the maximum depth of nested objects.
