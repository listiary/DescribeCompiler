========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── item_or_expression
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|' \n\t\n\tsynthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')