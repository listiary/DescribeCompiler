========================================
Source Code (between the arrows)
========================================

🡆fabrics <xpXWehDW> [https://www.notube.com/watch?v=hTui12lKus]-> //comment here

    wool fabrics <TcD3LcoW>,
    cotton fabrics[https://www.notube.com/watch?v=hTui12lKus] <thZBzyNc>,
    silk fabrics <dOlQGMJ4>[https://www.notube.com/watch?v=hTui12lKus],
    synthetic fabrics <Ln7Y7Dme>[https://www.notube.com/watch?v=hTui12lKus];//comment last🡄

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
│   │   │   ├── T(DATA|'xpXWehDW')
│   │   │   └── T(RIGHT_ARROW|'> ')
│   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'> ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'\r\n    wool fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'TcD3LcoW')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus] ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'thZBzyNc')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'dOlQGMJ4')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       ├── tag
│   │       │   ├── T(LEFT_ARROW|'<')
│   │       │   ├── T(DATA|'Ln7Y7Dme')
│   │       │   └── T(RIGHT_ARROW|'>')
│   │       └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')