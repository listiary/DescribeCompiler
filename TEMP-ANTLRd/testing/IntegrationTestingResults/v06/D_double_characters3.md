========================================
Source Code (between the arrows)
========================================

🡆fa \ br\ics\ ->

    wool\fabrics,
    \cotton fabrics,
    \ silk \ fabrics,
    synthetic fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'br')
│   │   └── text_chunk
│   │       └── T(DATA|'cs')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'\n\n    wool')
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'abrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'\n    ')
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'otton fabrics')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|'\n    ')
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|'silk ')
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n    synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')