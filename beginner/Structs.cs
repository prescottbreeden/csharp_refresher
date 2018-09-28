namespace basics
{
    public struct RgbColor 
    {
        public int Red;
        public int Green;
        public int Blue;

        /*

        "structs" are 'value types' -- lives on the stack
        "classes" are 'reference types' -- lives on the stack but points to heap memory

        value types always contain a value
        references types hold pointers to where the values are located

        this means that reference types are capable of holding null-reference

        copying a reference type only adds extra pointers to the values
        copying a value type creates two instances of the values

        Best to use structs when you need something small and lightweight, like RGB color here
        or if you're dealing with something like a point that has an X and a Y.  Especially if it
        is something you might created thoudands of instances of a struct will be more efficient

         */
    }
}
