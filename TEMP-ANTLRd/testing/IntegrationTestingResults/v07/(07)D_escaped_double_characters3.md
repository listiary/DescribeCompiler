========================================
Source Code (between the arrows)
========================================

🡆fa \\ br\\ics\\ <rDD37re8> ->

    wool\\fabrics <uCzQa\\\\1uW>,
    \\cotton fabrics <UxMKgYjI\\>,
    \\ silk \\ fabrics <Ux6\\wwQBT>,
    synthetic fabrics\\ <\\dbpyUcza>;🡄

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
│   │   │   └── T(DATA|' <rDD37re8')
│   │   └── text_chunk
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
│   │   │   │   │   └── T(DATA|'fabrics <uCzQa')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'1uW')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics <UxMKgYjI')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   └── text_chunk
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
│   │   │   │   │   └── T(DATA|' fabrics <Ux6')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wwQBT')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics')
│   │       ├── text_chunk
│   │       │   └── T(ESCAPE_ESCAPE|'\\')
│   │       ├── text_chunk
│   │       │   └── T(DATA|' <')
│   │       ├── text_chunk
│   │       │   └── T(ESCAPE_ESCAPE|'\\')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'dbpyUcza')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')