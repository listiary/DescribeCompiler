========================================
Source Code (between the arrows)
========================================

🡆fa \-> br\->ics ->

    wool fabrics,
    cotton fabrics,
    silk fabrics,
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
│   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_ARROW|'>')
│   │   ├── text_chunk
│   │   │   └── T(DATA|' br')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_ARROW|'>')
│   │   └── text_chunk
│   │       └── T(DATA|'ics ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n\n    wool fabrics')
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