#include <iostream>

template <typename T>
void ref_func(T& data) {
	// ...
}

template <typename T>
void con_ref_func(const T& data) {
	// ...
}

template <typename T>
void univ_ref_func(T&& data) {
	// ...
}

template <typename T>
void func(T dataa) {
	// ...
}

int main() {
	int num = 5;
	const int con_num = num;
	const int& con_ref_num = num;

	// Case 1. Parameter type is pointer or reference (&)
	ref_func(num);			// T : int,			data : int &
	ref_func(con_ref_num);	// T : const int,	data : const int &
	
	con_ref_func(con_num);	// T : int,			data : const int &

	// Case 2. Parameter type is universal reference (&&)
	univ_ref_func(num);		// T : int &,		data : int &
	univ_ref_func(con_num);	// T : const int &,	data : const int &
	univ_ref_func(5);		// T : int,			data : int &&

	// Case 3. Parameter type is value
	func(con_ref_num);		// T : int,			data : int

	const char* const str = "Hello, World!";
	func(str);				// T : const char*,	data : const char*
}