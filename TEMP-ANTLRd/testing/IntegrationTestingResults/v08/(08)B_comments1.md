========================================
Source Code (between the arrows)
========================================

🡆fabrics <KvtgGtnv>[] -> //comment here [https://www.notube.com/watch?v=hTui12lKus]

    wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus],
    cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]<wpra8mUV>,
    silk fabrics <VFoIEr0T>[],
    synthetic fabrics <oI5DOuPh>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   ├── tag
│   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   ├── T(DATA|'KvtgGtnv')
│   │   │   └── T(RIGHT_ARROW|'>')
│   │   └── T(LINK|'[] ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'> ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'\r\n    wool fabrics ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'rUEqmXfk')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'wpra8mUV')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'VFoIEr0T')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'oI5DOuPh')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')