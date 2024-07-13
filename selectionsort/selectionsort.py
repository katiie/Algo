# Python code for SelectionSort Algorithm
def sort(arr):
    count = len(arr)
    for i in range(count):
        min_index = i
        j = i + 1
        while (j < count):
            if arr[min_index] > arr[j]:
                min_index = j
            j += 1
        if arr[min_index] < arr[i]:
            (arr[i], arr[min_index]) = (arr[min_index], arr[i])
    return arr


"""sample test cases"""
"""
print(sort([5, 6, 7, 1, 2, 4, 6]))
data = [-2, 45, 3, 0, 11, -9, -1, 3, -5]
print(sort(data))
data = [-1, 4, 45, 3, 0, 11, -9, -1, 3, -5, 20]
print(sort(data))
data = [1, 2, 9, 8, 7, 4, 5, 1]
print(sort(data))
data = [12, 11, 13, 5, 6, 10, 2, 5, 1]
print(sort(data))
"""
