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
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|' ')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')