========================================
Source Code (between the arrows)
========================================

🡆fabrics -> ;🡄

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
│   │           └── T(DATA|' ')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')