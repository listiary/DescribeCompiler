========================================
Source Code (between the arrows)
========================================

🡆fabrics -> //comment here

    wool fabrics,
    cotton fabrics,
    silk fabrics,
    synthetic fabrics;//comment last🡄

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
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|' ')
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n    wool fabrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'\n    cotton fabrics')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'\n    silk fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n    synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')