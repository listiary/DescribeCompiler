========================================
Source Code (between the arrows)
========================================

🡆fa \\ br\\ics\\ <rDD37re8> ->

    wool\\fabrics <uCzQa1uW>,
    \\cotton fabrics <UxMKgYjI>,
    \\ silk \\ fabrics <Ux6wwQBT>,
    synthetic fabrics\\ <dbpyUcza>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   ├── text_chunk
│   │   │   └── T(DATA|' br')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'ics')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   ├── text_chunk
│   │   │   └── T(DATA|' ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'rDD37re8')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'uCzQa1uW')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'UxMKgYjI')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' silk ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|' fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'Ux6wwQBT')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics')
│   │       ├── text_chunk
│   │       │   └── T(ESCAPE_ESCAPE|'\\')
│   │       ├── text_chunk
│   │       │   └── T(DATA|' ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'dbpyUcza')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')