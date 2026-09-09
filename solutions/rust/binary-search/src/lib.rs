pub fn find(array: &[i32], key: i32) -> Option<usize> {
    let mut left = 0;
    let mut right = array.len();

    while left < right {
        let middle = (left + right) / 2;

        if &array[middle] == &key {
            return Some(middle);
        } else if &array[middle] < &key {
            left = middle + 1;
        } else {
            right = middle
        }
    }

    None
}
