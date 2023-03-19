#include <iostream>

void anyStructAllowed(void* data) {


}

struct aStruct1 {
    float a;
};

struct aStruct2 {
    float a;
};

int main() {
    aStruct1 data;
    anyStructAllowed(&data);
}
