========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        //dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* ->Comments, man */     cotton fabrics <0RdNAvNs> ;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics <QuvD4gqX')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>        ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'\r\n    wool fabrics <VBsu8OpW')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|', ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(NEWLINE|'\r\n')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'     cotton fabrics <0RdNAvNs')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'> ')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')