========================================
Source Code (between the arrows)
========================================

🡆fabrics <qJobcYNC> -> // comment here

    wool fabrics <WmtITd8B>[https://www.notube.com/watch?v=hTui12lKus],
    cotton fabrics <KGkvDUZH>[https://www.notube.com/watch?v=hTui12lKus],
    silk fabrics <BbiZz4Ie>[https://www.notube.com/watch?v=hTui12lKus],
    synthetic fabrics <gCWv1P46>[https://www.notube.com/watch?v=hTui12lKus];

// comment last🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'qJobcYNC')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'> ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'WmtITd8B')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'KGkvDUZH')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'BbiZz4Ie')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       ├── tag
│   │       │   ├── T(LEFT_ARROW|'<')
│   │       │   ├── T(DATA|'gCWv1P46')
│   │       │   └── T(RIGHT_ARROW|'>')
│   │       └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   └── T(TERMINATOR|';\r\n\r\n')
└── T(EOF|'<EOF>')