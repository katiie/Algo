# Ruby code for Quicksort Algorithm
# https://en.wikipedia.org/wiki/Quicksort
def sort(array)
    arr_length = array.length - 1
    i=0
    for i in 0..arr_length do
        min_index = i
        j = i + 1
        while (j <= arr_length)
            if array[min_index] > array[j]
                min_index = j
            end
            j += 1
        end
        if array[min_index] < array[i]
            temp = array[i]
            array[i] = array[min_index]
            array[min_index] = temp
        end
    end
    return array
end

"""sample test cases"""
"""
puts(sort([5, 6, 7, 1, 2, 4, 6]))
data = [-2, 45, 3, 0, 11, -9, -1, 3, -5]
puts(sort(data))
data = [-1, 4, 45, 3, 0, 11, -9, -1, 3, -5, 20]
puts(sort(data))
data = [1, 2, 9, 8, 7, 4, 5, 1]
puts(sort(data))
data = [12, 11, 13, 5, 6, 10, 2, 5, 1]
puts(sort(data))
"""