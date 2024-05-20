========================================
Source Code (between the arrows)
========================================

🡆fa \, br\->ics\// ->

    wool\;fabrics,
    \,cotton fabrics,
    silk fabrics,
    synthetic fabrics\;;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │   ├── text_chunk
│   │   │   └── T(DATA|' br')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_ARROW|'>')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'ics')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_LCOMMENT|'\//')
│   │   └── text_chunk
│   │       └── T(DATA|' ')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'\n\n    wool')
│   │   │   ├── text_chunk
│   │   │   │   └── T(ESCAPE_TERMINATOR|'\;')
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'\n    ')
│   │       │   ├── text_chunk
│   │       │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'cotton fabrics')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'\n    silk fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   ├── text_chunk
│   │                   │   └── T(DATA|'\n    synthetic fabrics')
│   │                   └── text_chunk
│   │                       └── T(ESCAPE_TERMINATOR|'\;')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')