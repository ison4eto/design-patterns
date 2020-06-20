In the Adapter pattern two incompatible types can communicate between each other as the adapter acts as a translator between the two. This is something like when we convert an interface of one class into an interface expected by the client. It is like the problem of inserting a new three-prong electrical plug into an old two-prong wall outlet; some kind of adapter or intermediary is necessary.

- Target(_Compound_) - the interface used by the client 
- Client (_Example_) - uses the target objects
- Adaptee (_ChemicalDatabank_) - defines an object the needs adaptation and defaut values
- Adapter (_RichCompound_) - adapts Adaptee interface to target interface