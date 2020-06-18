In this pattern there is a single chain of passing a request with many handlers.
Each sender keeps a single reference to the head of the chain, and each receiver 
keeps a single reference to its immediate successor in the chain. 
This pattern is used to process those requests that are varied.